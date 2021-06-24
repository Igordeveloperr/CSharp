using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Шаблоны
{
    public class Apple : Product
    {
        public override void PrintInformation()
        {
            Console.WriteLine($"Apple: {CalculateCalorie()}");
        }
        private int CalculateCalorie()
        {
            int calories = (53 * 102) / 100;
            return calories;
        }
    }
}
