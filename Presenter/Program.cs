/*
 *   PraiseBase Presenter
 *   The open source lyrics and image projection software for churches
 *
 *   http://praisebase.org
 *
 *   This program is free software; you can redistribute it and/or
 *   modify it under the terms of the GNU General Public License
 *   as published by the Free Software Foundation; either version 2
 *   of the License, or (at your option) any later version.
 *
 *   This program is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU General Public License for more details.
 *
 *   You should have received a copy of the GNU General Public License
 *   along with this program; if not, write to the Free Software
 *   Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 *
 */

using System;
// using log4net.Config;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using PraiseBase.Presenter.Editor;
using PraiseBase.Presenter.Forms;
using PraiseBase.Presenter.Manager;
using PraiseBase.Presenter.Persistence.Setlists;
using PraiseBase.Presenter.Presenter;
using PraiseBase.Presenter.Properties;

namespace PraiseBase.Presenter
{
    internal class Program
    {
        private static readonly DateTime StartTime = DateTime.UtcNow;
        private static Mutex _mutex;
        private static ILogger _logger;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

            if (args.Any())
                throw new NotImplementedException("SongEditor / Setlist at startup");

            var host = CreateHostBuilder().Build();
            var logger = host.Services.GetRequiredService<ILogger<Program>>();

            _logger = logger;

            Configure(host, logger);
            InitData(host.Services, logger);

            var mainWindow = host.Services.GetRequiredService<MainWindow>();

            Application.Run(mainWindow);

            GC.KeepAlive(_mutex);

            // string setlistFile = null;
            // string songFile = null;

            // // Detect if program is called with a setlist file as argument
            // if (args.Length == 1)
            // {
            //     if (File.Exists((args[0])))
            //     {
            //         string ext = Path.GetExtension(args[0]);
            //         if (ext == "." + SetlistWriter.FileExtension)
            //         {
            //             setlistFile = args[0];
            //         }
            //         else
            //         {
            //             songFile = args[0];
            //         }
            //     }
            // }

            // Form mw;
            // if (songFile != null)
            // {
            //     mw = new SongEditor(Settings.Default, imgManager, songFile);
            // }
            // else
            // {
            //     mw = new MainWindow(songManager, imgManager, bibleManager, setlistFile);
            // }
            // Application.Run(mw);
        }

        private static void UpgradeSettingsIfRequired()
        {
            if (Settings.Default.UpgradeRequired)
            {
                Settings.Default.Upgrade();
                Settings.Default.UpgradeRequired = false;
                Settings.Default.Save();
            }
        }

        private static Mutex ExitIfAlreadyRunning()
        {
            string strLoc = Assembly.GetExecutingAssembly().Location;
            FileSystemInfo fileInfo = new FileInfo(strLoc);
            string sExeName = fileInfo.Name;
            string mutexName = "Global\\" + sExeName;

            try
            {
                Mutex mutex = Mutex.OpenExisting(mutexName);

                //since it hasn’t thrown an exception, then we already have one copy of the app open.
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                String appTitle = ((AssemblyProductAttribute)attributes[0]).Product;

                MessageBox.Show(StringResources.ProgramInstanceAlreadyRunning, appTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(-1);

                return mutex;
            }
            catch
            {
                //since we didn’t find a mutex with that name, create one
                return new Mutex(true, mutexName);
            }
        }

        private static IHostBuilder CreateHostBuilder()
            => Host.CreateDefaultBuilder()
                .UseDefaultServiceProvider((context, options) =>
                {
                    options.ValidateOnBuild = true;
                    options.ValidateScopes = !context.HostingEnvironment.IsProduction();
                })
                .ConfigureLogging((context, builder) =>
                {
                    builder.ClearProviders();
                    builder.AddConfiguration(context.Configuration.GetSection("Logging"));
                    builder.SetMinimumLevel(LogLevel.Debug);
                    builder.AddSimpleConsole(options =>
                    {
                        options.IncludeScopes = true;
                        options.ColorBehavior = LoggerColorBehavior.Default;
                        options.SingleLine = false;
                        options.TimestampFormat = "O";
                        options.UseUtcTimestamp = true;
                    });
                })
                .ConfigureServices((context, services) =>
                {
                    // Check Data directory
                    if (SettingsUtil.SetDefaultDataDirIfEmpty(Settings.Default))
                    {
                        Settings.Default.Save();
                    }

                    services.AddOptions<PresenterOptions>()
                        .Configure(options =>
                        {
                            var settings = Settings.Default;

                            options.DataDirectory = settings.DataDirectory;
                            options.BibleDirectory = SettingsUtil.GetBibleDirPath(settings);
                            options.ImageDirectory = SettingsUtil.GetImageDirPath(settings);
                            options.SongDirectory = SettingsUtil.GetSongDirPath(settings);
                            options.ThumbDirectory = SettingsUtil.GetThumbDirPath(settings);

                            options.ThumbSize = settings.ThumbSize = new Size(80, 60);
                            options.ImageSize = new Size(1024, 768);
                            options.ProjectionBackColor = settings.ProjectionBackColor;
                        });

                    services.AddSingleton<SongManager>();
                    services.AddSingleton<ImageManager>();
                    services.AddSingleton<BibleManager>();
                    services.AddTransient<MainWindow>();
                    services.AddTransient<LoadingScreen>();
                })
                .ConfigureAppConfiguration((context, configuration) =>
                {
                    // configuration.
                });
        // .ConfigureHostConfiguration(builder =>
        // {
        //     builder.
        // });

        private static void Configure(IHost host, ILogger<Program> logger)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UpgradeSettingsIfRequired();

            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(Settings.Default.SelectedCulture);

            logger.LogDebug("Set culture to " + Thread.CurrentThread.CurrentUICulture);

            _mutex = ExitIfAlreadyRunning();
        }

        private static void InitData(IServiceProvider services, ILogger logger)
        {
            var loadingForm = Settings.Default.ShowLoadingScreen ? services.GetRequiredService<LoadingScreen>() : null;
            var imageManager = services.GetRequiredService<ImageManager>();
            var songManager = services.GetRequiredService<SongManager>();

            loadingForm?.SetLabel("PraiseBase Presenter wird gestartet...");
            loadingForm?.Show();

            loadingForm?.SetLabel("Prüfe Miniaturbilder...");
            imageManager.CheckThumbs(true);

            loadingForm?.SetLabel("Lade Liederdatenbank...");
            songManager.Reload();

            GC.Collect();
            loadingForm.Close();
            // loadingForm.Dispose();

            logger.LogDebug("Loading took " + (DateTime.Now - StartTime).TotalSeconds + " seconds!");
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is Exception argsEx)
                _logger?.LogError(argsEx, "An unhandled exception occurred");
            else
                _logger?.LogError("An unhandled exception occurred"); //+ e.ExceptionObject);

            try
            {
                string caption = StringResources.FatalError;
                string message = string.Format(StringResources.FatalErrorOccuredProgramTerminated, e.ExceptionObject.GetType()) + Environment.NewLine + Environment.NewLine;

                // Show exception message
                if (e.ExceptionObject != null && typeof(Exception).IsAssignableFrom(e.ExceptionObject.GetType()))
                {
                    var ex = ((Exception)e.ExceptionObject);
                    message += ex.Message + Environment.NewLine + Environment.NewLine;
                }
                message += StringResources.AdditionalDetailsCanBeFoundInLogfile + Environment.NewLine + Environment.NewLine;

                var url = Settings.Default.BugReportUrl;
                if (!string.IsNullOrEmpty(url))
                {
                    message += StringResources.PleaseReportBugToDeveloperByClickingOnHelpButton;
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 0, url);
                }
                else
                {
                    MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                _logger?.LogError(ex, "An exception ocurred while trying to display the unhandled exception message box");
            }

            Process.GetCurrentProcess().Kill();
        }
    }
}