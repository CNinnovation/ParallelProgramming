namespace Wrox.ProCSharp.Async;

public class SearchItemResult : BindableBase
{
    private string _title = string.Empty;
    public string Title
    {
        get => _title;
        set => SetProperty(ref _title, value);
    }

    private string _url = string.Empty;
    public string Url
    {
        get => _url;
        set => SetProperty(ref _url, value);
    }

    private string _thumbnailUrl = string.Empty;
    public string ThumbnailUrl
    {
        get => _thumbnailUrl;
        set => SetProperty(ref _thumbnailUrl, value);
    }

    private string _source = string.Empty;
    public string Source
    {
        get => _source;
        set => SetProperty(ref _source, value);
    }
}
