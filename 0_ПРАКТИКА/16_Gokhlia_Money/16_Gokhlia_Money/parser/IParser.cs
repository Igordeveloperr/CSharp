using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Gokhlia_Money.parser
{
    interface IParser<T> where T: class
    {
        T Parse(IHtmlDocument document, string tag, string className);
    }
}
