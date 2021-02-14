using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Gokhlia_Money.parser
{
    class ParserSettings : IParserSettings
    {
        public string Url { get; } = "https://apibitcoins.000webhostapp.com/";
    }
}
