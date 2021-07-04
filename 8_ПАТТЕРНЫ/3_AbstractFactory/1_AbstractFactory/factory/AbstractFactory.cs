using _1_AbstractFactory.components;
using _1_AbstractFactory.playments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AbstractFactory.factory
{
    internal abstract class AbstractFactory
    {
        public abstract List<RadioComponent> CreateComponent();
        public abstract Playment CreatePlayment();
    }
}
