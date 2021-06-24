using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _2_Шаблоны
{
    public class Bread : Product
    {
        public override void PrintInformation()
        {
            Console.WriteLine($"Bread information: {CountBread()}");
        }

        private int CountBread()
        {
            return 100 + 100 * 400;
        }
    }
}
