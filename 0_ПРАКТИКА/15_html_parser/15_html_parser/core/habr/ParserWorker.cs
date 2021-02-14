using _15_html_parser.core.loaders;
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_html_parser.core.habr
{
    class ParserWorker <T> where T: class
    {
        readonly IParser<T> Parser;
        internal IParserSettings Settings;
        HtmlLoader loader;
        private bool IsActive;

        public event Action<object, T> OnNewData;
        public event Action<object> OnCompleted;
        public ParserWorker(IParser<T> parser)
        {
            Parser = parser;
        }
        public ParserWorker(IParser<T> parser, IParserSettings settings)
        {
            Parser = parser;
            Settings = settings;
        }

        public void Start()
        {
            loader = new HtmlLoader(Settings);
            IsActive = true;
            Worker();
        }

        public void Stop()
        {
            IsActive = false;
        }

        private async void Worker()
        {
            for(int i = Settings.StartPoint; i <= Settings.EndPoint; i++)
            {
                if (!IsActive)
                {
                    OnCompleted?.Invoke(this);
                    return; 
                }
                var source = await loader.GetSourceByPageIdAsync(i);
                var domParser = new HtmlParser();
                var document = await domParser.ParseDocumentAsync(source);
                var result = Parser.Parse(document);
                OnNewData?.Invoke(this, result);
            }
            OnCompleted?.Invoke(this);
            IsActive = false;
        }
    }
}
