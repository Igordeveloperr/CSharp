using _16_Gokhlia_Money.chart;
using _16_Gokhlia_Money.parser.loaders;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using System;
using System.Windows.Forms;

namespace _16_Gokhlia_Money.parser
{
    internal class ParserInterface<T> where T : class
    {
        public RichTextBox listBox;
        private Parser Parser;
        private ParserSettings Settings;
        private bool IsActive;
        private HtmlLoader Loader;

        public event Action<object, string[]> OnNewData;
        public event Action<object> OnClose;

        public ParserInterface(Parser parser, RichTextBox list)
        {
            if(parser != null)
            {
                Parser = parser;
                listBox = list;
            }
        }
        public ParserInterface(Parser parser, ParserSettings settings)
        {
            if (parser != null && settings != null)
            {
                Parser = parser;
                Settings = settings;
            }
        }
        public void Start()
        {
            Loader = new HtmlLoader(Settings);
            IsActive = true;
            Work();
        }
        public void Stop()
        {
            IsActive = false;
        }
        private async void Work()
        {
            if (!IsActive)
            {
                OnClose.Invoke(this);
                return;
            }
            string source = await Loader.LoadDocument();
            listBox.Text = source;
            var domParser = new HtmlParser();
            var document = await domParser.ParseDocumentAsync(source);
            var money = Parser.Parse(document, "td", "moneyUp");
            OnNewData.Invoke(this, money);
            OnClose.Invoke(this);
            IsActive = false;
        }
    }
}
