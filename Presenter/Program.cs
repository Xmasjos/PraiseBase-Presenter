﻿/*
 *   PraiseBase Presenter
 *   The open source lyrics and image projection software for churches
 *
 *   http://code.google.com/p/praisebasepresenter
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
 *   Author:
 *      Nicolas Perrenoud <nicu_at_lavine.ch>
 *   Co-authors:
 *      ...
 *
 */

using System;
using System.Windows.Forms;
using Pbp.Forms;
using Pbp.Properties;
using Pbp.Manager;
using System.Globalization;
using System.Collections.Generic;

namespace Pbp
{
    internal static class Program
    {
        static public List<CultureInfo> AvailableLanguages = new List<CultureInfo>();

        static Program()
        {
            AvailableLanguages.Add(CultureInfo.CreateSpecificCulture("de-CH"));
            AvailableLanguages.Add(CultureInfo.CreateSpecificCulture("en-US"));
        }
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            DateTime startTime = DateTime.Now;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture(Settings.Default.SelectedCulture);

            // code to ensure that only one copy of the software is running.
            System.Threading.Mutex mutex;
            string strLoc = System.Reflection.Assembly.GetExecutingAssembly().Location;
            System.IO.FileSystemInfo fileInfo = new System.IO.FileInfo(strLoc);
            string sExeName = fileInfo.Name;
            string mutexName = "Global\\" + sExeName;
            try
            {
                mutex = System.Threading.Mutex.OpenExisting(mutexName);

                //since it hasn’t thrown an exception, then we already have one copy of the app open.
                object[] attributes = System.Reflection.Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(System.Reflection.AssemblyProductAttribute), false);
                String appTitle = ((System.Reflection.AssemblyProductAttribute)attributes[0]).Product;

                MessageBox.Show(Properties.StringResources.ProgramInstanceAlreadyRunning, appTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }
            catch
            {
                //since we didn’t find a mutex with that name, create one
                mutex = new System.Threading.Mutex(true, mutexName);
            }

            // Check Data directory
            if (Settings.Default.DataDirectory == "")
            {
                Settings.Default.DataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + System.IO.Path.DirectorySeparatorChar + Settings.Default.DataDirDefaultName;
                if (System.IO.Directory.Exists(Settings.Default.DataDirectory))
                {
                    System.IO.Directory.CreateDirectory(Settings.Default.DataDirectory);
                }
                Settings.Default.Save();
            }

            if (Settings.Default.ShowLoadingScreen)
            {
                LoadingScreen ldg = new LoadingScreen();
                ldg.setLabel("PraiseBase Presenter wird gestartet...");
                ldg.Show();

                ldg.setLabel("Prüfe Miniaturbilder...");
                ImageManager.Instance.CheckThumbs();

                ldg.setLabel("Lade Liederdatenbank...");
                SongManager.Instance.Reload();

                GC.Collect();
                ldg.Close();
                ldg.Dispose();
            }
            else
            {
                ImageManager.Instance.CheckThumbs();
                SongManager.Instance.Reload();
                GC.Collect();
            }

            Console.WriteLine("Loading took " + (DateTime.Now - startTime).TotalSeconds + " seconds!");
            Application.Run(MainWindow.Instance);
            GC.KeepAlive(mutex);
        }
    }
}