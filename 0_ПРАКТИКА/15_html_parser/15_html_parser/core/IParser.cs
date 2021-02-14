using AngleSharp.Html.Dom;

namespace _15_html_parser.core
{
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}
