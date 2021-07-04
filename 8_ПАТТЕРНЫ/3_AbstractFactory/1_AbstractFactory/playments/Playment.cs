using _1_AbstractFactory.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AbstractFactory.playments
{
    internal abstract class Playment
    {
        public abstract void addRadioComponent(List<RadioComponent> components);
    }
}
