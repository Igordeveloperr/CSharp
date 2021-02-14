using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_Gokhlia_Money.parser.loaders
{
    internal class HtmlLoader
    {
        readonly private ParserSettings Settings;
        readonly private HttpClient client;
        public HtmlLoader(ParserSettings settings)
        {
            if(settings != null)
            {
                Settings = settings;
                client = new HttpClient();
            }
        }

        public async Task<string> LoadDocument()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            var response = await client.GetAsync(Settings.Url);
            string document = null;
            if(response != null && response.StatusCode == HttpStatusCode.OK)
            {
                document = await response.Content.ReadAsStringAsync();
            }

            return document;
        }
    }
}
