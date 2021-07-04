using _1_AbstractFactory.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AbstractFactory.playments
{
    internal class Gokhlia : Playment
    {
        public override void addRadioComponent(List<RadioComponent> components)
        {
            int max = components.Count;
            int index = new Random().Next(0, max);
            string info = components[index].PrintInfo();
            Console.WriteLine($"Gokhlia прокачал компонент: {info}");
        }
    }
}
