using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AbstractFactory.components
{
    internal class Atmega328 : RadioComponent
    {
        public override string PrintInfo()
        {
            return "МК-atmega328, шизоидный челик";
        }
    }
}
