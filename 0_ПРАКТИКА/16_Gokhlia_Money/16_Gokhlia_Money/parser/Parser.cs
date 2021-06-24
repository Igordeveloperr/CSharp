using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_Gokhlia_Money.parser
{
    internal class Parser: IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document, string tag, string className)
        {
            List<string> list = new List<string>();
            var items = document.QuerySelectorAll($"{tag}");
            foreach (var item in items)
            {
                if(item.ClassName != null && item.ClassName.Contains($"{className}"))
                {
                    list.Add(item.TextContent);
                }
            }

            return list.ToArray();
        }
    }
}
