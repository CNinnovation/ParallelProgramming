using System.Net;
using System.Xml.Linq;

namespace Wrox.ProCSharp.Async;

public class FlickrRequest : IImageRequest
{
    private const string AppId = "enter your Flickr app-id here";

    public FlickrRequest()
    {
        Count = 50;
        Page = 1;
    }

    public required string SearchTerm { get; set; }

    public string Url => $"https://api.flickr.com/services/rest?api_key={AppId}&method=flickr.photos.search&content_type=1&text={SearchTerm}&per_page={Count}&page={Page}";

    public int Count { get; set; }
    public int Page { get; set; }

    public IEnumerable<SearchItemResult> Parse(string xml)
    {
        XElement respXml = XElement.Parse(xml);
        return from item in respXml.Descendants("photo")
               select new SearchItemResult
               {
                   Title = new string(item.Attribute("title")!.Value.Take(50).ToArray()),
                   Url = $"http://farm{item.Attribute("farm")!.Value}.staticflickr.com/{item.Attribute("server")!.Value}/{item.Attribute("id")!.Value}_{item.Attribute("secret")!.Value}_z.jpg",
                   ThumbnailUrl = $"http://farm{item.Attribute("farm")!.Value}.staticflickr.com/{item.Attribute("server")!.Value}/{item.Attribute("id")!.Value}_{item.Attribute("secret")!.Value}_t.jpg",
                   Source = "Flickr"
               };
    }

    public ICredentials? Credentials => null;
}
