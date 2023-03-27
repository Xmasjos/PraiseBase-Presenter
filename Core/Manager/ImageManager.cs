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
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using Core;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PraiseBase.Presenter.Model.Song;
using PraiseBase.Presenter.Util;

namespace PraiseBase.Presenter.Manager
{
    public class ImageManager
    {
        private const string ExcludeThumbDirName = "[Thumbnails]";
        private readonly string[] _imgExtensions = { "*.jpg", ".jpeg" };
        private readonly IOptionsMonitor<PresenterOptions> _optionsMonitor;
        private readonly ILogger<ImageManager> _logger;

        /// <summary>
        ///     Private constructor
        /// </summary>
        public ImageManager(IOptionsMonitor<PresenterOptions> optionsMonitor, ILogger<ImageManager> logger)
        {
            _optionsMonitor = optionsMonitor ?? throw new ArgumentNullException(nameof(optionsMonitor));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        /// <summary>
        ///     Base path to the image directory
        /// </summary>
        public string ImageDirPath => _optionsMonitor.CurrentValue.ImageDirectory;

        /// <summary>
        ///     Base path to the thumbs directory
        /// </summary>
        public string ThumbDirPath => _optionsMonitor.CurrentValue.ThumbDirectory;

        /// <summary>
        ///     Check and create thumbnails if necessary
        /// </summary>
        /// <param name="cleanup">If set to true, will cleanup images of which no original file exists</param>
        public void CheckThumbs(bool cleanup)
        {
            // Cleanup
            if (cleanup)
            {
                CleanupThumbs();
            }

            // Update thumbnails
            var imageDirPath = _optionsMonitor.CurrentValue.ImageDirectory;

            List<string> paths = new List<string>();
            foreach (var ext in _imgExtensions)
            {
                paths.AddRange(Directory.GetFiles(imageDirPath, ext, SearchOption.AllDirectories));
            }
            CheckThumbnailFiles(paths.ToArray());
        }

        /// <summary>
        /// Cleanup thumbnail images
        /// </summary>
        private void CleanupThumbs()
        {
            // Cleanup images of which no original file exists
            var thumbDirPath = _optionsMonitor.CurrentValue.ThumbDirectory;
            var imageDirPath = _optionsMonitor.CurrentValue.ImageDirectory;

            foreach (var ext in _imgExtensions)
            {
                var tumbPaths = Directory.GetFiles(thumbDirPath, ext, SearchOption.AllDirectories);
                foreach (var file in tumbPaths)
                {
                    var realImage = file.Replace(thumbDirPath, imageDirPath);
                    if (!File.Exists(realImage))
                    {
                        File.Delete(file);
                    }
                }
            }

            // Cleanup empty directories
            FileUtils.RemoveEmptySubdirectories(thumbDirPath);
        }

        private void CheckThumbnailFiles(string[] paths)
        {
            var thumbDirPath = _optionsMonitor.CurrentValue.ThumbDirectory;
            var imageDirPath = _optionsMonitor.CurrentValue.ImageDirectory;
            var defaultThumbSize = _optionsMonitor.CurrentValue.ThumbSize;

            var missingThumbsSrc = new List<string>();
            var missingThumbsTrg = new List<string>();
            foreach (var file in paths)
            {
                if (!file.Contains(ExcludeThumbDirName) && !file.StartsWith(thumbDirPath))
                {
                    var relativePath = file.Substring((imageDirPath + Path.DirectorySeparatorChar).Length);
                    var thumbPath = thumbDirPath + Path.DirectorySeparatorChar + relativePath;
                    if (!File.Exists(thumbPath))
                    {
                        missingThumbsSrc.Add(file);
                        missingThumbsTrg.Add(thumbPath);
                    }
                }
            }
            var cnt = missingThumbsSrc.Count;
            if (cnt > 0)
            {
                for (var i = 0; i < cnt; i++)
                {
                    ImageUtils.CreateThumb(missingThumbsSrc[i], missingThumbsTrg[i], defaultThumbSize);
                    if (i % 10 == 0)
                    {
                        var e = new ThumbnailCreateEventArgs(i, cnt);
                        OnThumbnailCreated(e);
                    }
                }
            }
        }

        public Image GetThumbFromRelPath(string relativePath)
        {
            var thumbDirPath = _optionsMonitor.CurrentValue.ThumbDirectory;

            if (File.Exists(thumbDirPath + Path.DirectorySeparatorChar + relativePath))
            {
                return Image.FromFile(thumbDirPath + Path.DirectorySeparatorChar + relativePath);
            }
            return null;
        }

        public Image GetImageFromRelPath(string relativePath)
        {
            var imageDirPath = _optionsMonitor.CurrentValue.ImageDirectory;

            if (File.Exists(imageDirPath + Path.DirectorySeparatorChar + relativePath))
            {
                return Image.FromFile(imageDirPath + Path.DirectorySeparatorChar + relativePath);
            }
            return null;
        }

        public Image GetImage(string path)
        {
            var defaultEmptyColor = _optionsMonitor.CurrentValue.ProjectionBackColor;

            if (path == null)
            {
                return ImageUtils.GetEmptyImage(_optionsMonitor.CurrentValue.ImageSize, defaultEmptyColor);
            }
            try
            {
                var img = GetImageFromRelPath(path);
                if (img != null)
                {
                    return img;
                }
                throw new Exception("Das Bild " + path + " existiert nicht!");
            }
            catch (Exception e)
            {
                _logger.LogError(e, "GetImage");
                return ImageUtils.GetEmptyImage(_optionsMonitor.CurrentValue.ImageSize, defaultEmptyColor);
            }
        }

        public Image GetImage(IBackground bg)
        {
            if (bg != null)
            {
                if (bg.GetType() == typeof(ImageBackground))
                {
                    return GetImage(((ImageBackground)bg).ImagePath);
                }
                if (bg.GetType() == typeof(ColorBackground))
                {
                    return ImageUtils.GetEmptyImage(_optionsMonitor.CurrentValue.ImageSize, ((ColorBackground)bg).Color);
                }
            }
            return null;
        }

        public Image GetThumb(IBackground bg)
        {
            var defaultThumbSize = _optionsMonitor.CurrentValue.ThumbSize;

            if (bg != null)
            {
                if (bg.GetType() == typeof(ImageBackground))
                {
                    var img = GetThumbFromRelPath(((ImageBackground)bg).ImagePath);
                    if (img != null)
                    {
                        return img;
                    }
                }
                else if (bg.GetType() == typeof(ColorBackground))
                {
                    return ImageUtils.GetEmptyImage(defaultThumbSize, ((ColorBackground)bg).Color);
                }
            }
            return ImageUtils.GetEmptyImage(defaultThumbSize, _optionsMonitor.CurrentValue.ProjectionBackColor);
        }

        /// <summary>
        ///     Searches images and returns their relative paths
        /// </summary>
        /// <param name="needle"></param>
        /// <returns></returns>
        public List<string> SearchImages(string needle)
        {
            var rootDir = _optionsMonitor.CurrentValue.ImageDirectory + Path.DirectorySeparatorChar;
            var rootDirStrLen = rootDir.Length;
            var thumbDirPath = _optionsMonitor.CurrentValue.ThumbDirectory;

            return (from ext in _imgExtensions from ims in Directory.GetFiles(rootDir, ext, SearchOption.AllDirectories) where !ims.Contains(ExcludeThumbDirName) && !ims.StartsWith(thumbDirPath) let haystack = Path.GetFileNameWithoutExtension(ims) where haystack.ToLower().Contains(needle) select ims.Substring(rootDirStrLen)).ToList();
        }

        public void ImportImage(string sourcePath)
        {
            ImportImage(sourcePath, null);
        }

        public void ImportImage(string sourcePath, string relativeTargetPath)
        {
            string target = _optionsMonitor.CurrentValue.ImageDirectory;
            if (relativeTargetPath != null)
            {
                target += "\\" + relativeTargetPath;
            }
            if (Directory.Exists(target))
            {
                target += "\\" + Path.GetFileName(sourcePath);
                File.Copy(sourcePath, target, true);
                CheckThumbnailFiles(new string[] { target });
                ImageImported?.Invoke(target);
            }
        }

        #region Events

        public delegate void ThumbnailCreate(ThumbnailCreateEventArgs e);

        public event ThumbnailCreate ThumbnailCreated;

        public class ThumbnailCreateEventArgs : EventArgs
        {
            public ThumbnailCreateEventArgs(int number, int total)
            {
                Number = number;
                Total = total;
            }

            public int Number { get; set; }
            public int Total { get; set; }
        }

        protected virtual void OnThumbnailCreated(ThumbnailCreateEventArgs e)
        {
            ThumbnailCreated?.Invoke(e);
        }

        public delegate void ImageImport(string path);

        public event ImageImport ImageImported;

        #endregion Events
    }
}