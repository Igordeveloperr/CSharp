using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Универсальные_типы
{
    public class Product
    {
        /*Type - это анонимный тип*/
        public string Name { get; }
        public int Volume { get; }
        public int Energy { get; }

        public Product(string name, int volume, int energy)
        {
            // TODO: по хорошему надо проверку
            Name = name;
            Volume = volume;
            Energy = energy;
        }
    }
}
