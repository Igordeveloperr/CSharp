using _1_AbstractFactory.components;
using _1_AbstractFactory.playments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AbstractFactory.factory
{
    internal class ArduinoFactory : AbstractFactory
    {
        public override List<RadioComponent> CreateComponent()
        {
            Atmega328 atmega = new Atmega328();
            Сapacitor сapacitor = new Сapacitor();
            List<RadioComponent> components = new List<RadioComponent>();
            components.Add(atmega);
            components.Add(сapacitor);
            return components;
        }

        public override Playment CreatePlayment()
        {
            Arduino arduino = new Arduino();
            return arduino;
        }
    }
}
