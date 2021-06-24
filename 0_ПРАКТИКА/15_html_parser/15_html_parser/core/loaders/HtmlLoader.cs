
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _15_html_parser.core.loaders
{
    class HtmlLoader
    {
        readonly HttpClient client;
        readonly string Url;

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            Url = $"{settings.BaseUrl}/{settings.Prefix}/";
        }

        public async Task<string> GetSourceByPageIdAsync(int id)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            var currentUrl = Url.Replace("{currentId}", id.ToString());
            // получение данных через указанную ссылку
            var response = await client.GetAsync(currentUrl);
            string source = null;
            // проверка ответа на валидность
            if(response != null && response.StatusCode == HttpStatusCode.OK)
            {   
                source = await response.Content.ReadAsStringAsync();
            }

            return source;
        }
    }
}
