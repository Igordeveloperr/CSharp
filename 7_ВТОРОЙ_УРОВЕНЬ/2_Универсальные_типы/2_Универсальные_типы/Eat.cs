using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Универсальные_типы
{
    public class Eat<T, TT>
        where T:Product
        where TT: Apple
    {
        public int Volume { get; private set; }
        public void Add(T product)
        {
            Volume += product.Volume * product.Energy;
            Console.WriteLine(Volume);
        }
    }
}
