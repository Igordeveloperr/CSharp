using _1_AbstractFactory.components;
using _1_AbstractFactory.playments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AbstractFactory.factory
{
    internal class IskraFactory : AbstractFactory
    {
        public override List<RadioComponent> CreateComponent()
        {
            Сapacitor сapacitor = new Сapacitor();
            List<RadioComponent> components = new List<RadioComponent>();
            components.Add(сapacitor);
            return components;
        }

        public override Playment CreatePlayment()
        {
            Iskra iskra = new Iskra();
            return iskra;
        }
    }
}
