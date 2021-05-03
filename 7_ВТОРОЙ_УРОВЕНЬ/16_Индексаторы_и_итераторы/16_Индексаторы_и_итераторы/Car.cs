using System;
using System.Collections.Generic;
using System.Text;

namespace _16_Индексаторы_и_итераторы
{
    class Car
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public override string ToString()
        {
            return $"{Name}-{Number}";
        }
    }
}
