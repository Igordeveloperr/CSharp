using _1_AbstractFactory.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AbstractFactory.playments
{
    internal class Iskra : Playment
    {
        public override void addRadioComponent(List<RadioComponent> components)
        {
            string info = string.Empty;
            if (components == null) return;
            foreach (RadioComponent component in components)
            {
                info = $"Iskra add: {component.PrintInfo()}";
                Console.WriteLine(info);
            }
        }
    }
}
