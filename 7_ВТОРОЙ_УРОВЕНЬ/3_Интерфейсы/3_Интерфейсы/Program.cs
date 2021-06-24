using System;
using System.Collections.Generic;

namespace _3_Интерфейсы
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<ICar>();
            list.Add(new LadaSeven());
            list.Add(new Reno());

            foreach(var car in list)
            {
                Console.WriteLine(car.Move(100, 10));
            }

            ICar cyborg = new Cyborg();
            Console.WriteLine(cyborg.Move(100, 10));

            IPerson cyborg2 = new Cyborg();
            Console.WriteLine(cyborg2.Move(100, 10));
        }
    }
}
