using _1_AbstractFactory.components;
using _1_AbstractFactory.playments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AbstractFactory.factory
{
    internal class GokhliaFactory : AbstractFactory
    {
        public override List<RadioComponent> CreateComponent()
        {
            List<RadioComponent> components = new List<RadioComponent>();
            Atmega328 atmega328 = new Atmega328();
            Сapacitor сapacitor = new Сapacitor();
            components.Add(сapacitor);
            components.Add(atmega328);
            return components;
        }

        public override Playment CreatePlayment()
        {
            return new Gokhlia();
        }
    }
}
