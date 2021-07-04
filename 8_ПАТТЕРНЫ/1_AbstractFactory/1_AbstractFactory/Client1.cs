using _1_AbstractFactory.components;
using _1_AbstractFactory.factory;
using _1_AbstractFactory.playments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AbstractFactory
{
    internal class Client1
    {
        private List<RadioComponent> _radioComponents;
        private Playment _playment;
        public Client1(AbstractFactory factory)
        {
            _radioComponents = factory.CreateComponent();
            _playment = factory.CreatePlayment();
        }
        public void Run()
        {
            _playment.addRadioComponent(_radioComponents);
        }
    }
}
