using AngleSharp.Html.Dom;
using System.Collections.Generic;

namespace _15_html_parser.core.habr
{
    class Parser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var list = new List<string>();
            // получаю из HTML документа все теги определенного типа
            var items = document.QuerySelectorAll("a");
            foreach(var item in items)
            {
                // проверка наличия тега "class" и наличия определенного значения
                if(item.ClassName != null && item.ClassName.Contains("post__title_link"))
                {   
                    // добавление текстового контента тега в массив
                    list.Add(item.TextContent);
                }
            }
            // преобразую лист в массив
            return list.ToArray();
        }
    }
}
