using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AbstractFactory.components
{
    internal class Сapacitor : RadioComponent
    {
        public override string PrintInfo()
        {
            return "Электролитический конденсатор 100мкФ";
        }
    }
}
