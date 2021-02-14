
namespace _15_html_parser.core.habr
{
    class Settings : IParserSettings
    {   
        public Settings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }
        public string BaseUrl { get; set; } = "https://habr.com/ru";
        public string Prefix { get; set; } = "page{currentId}";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
    }
}
