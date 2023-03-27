
using System.Collections.Specialized;

namespace Core;

public class PresenterOptions
{
    public const string Presenter = "Presenter";

    public string DataDirectory { get; set; }
    public string SongDirectory { get; set; }
    public string ImageDirectory { get; set; }
    public string ThumbDirectory { get; set; }
    public string BibleDirectory { get; set; }

    public Size ThumbSize { get; set; }
    public Size ImageSize { get; set; }
    public Color ProjectionBackColor { get; set; }

    public Size MainWindowSize { get; set; }
    public StringCollection SongParts { get; set; }
}