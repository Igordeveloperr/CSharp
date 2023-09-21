using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class MathFunction
    {
        private const int MIN_VALUE = -1;
        private const byte ROUND = 6;
        public double Calculate(double x)
        {
            double arg;
            if(x < MIN_VALUE)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("D(f) = [-1; +infinity)");
                arg = MIN_VALUE;
            }
            else
            {
                arg = x;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            return Math.Round(x - Math.Sqrt(Math.Log(arg + 2)), ROUND);
        }

        public double CalculateFirstDerivative(double x)
        {
            return Math.Round(1 - 1 / (2 * Math.Log(Math.Sqrt(x + 2)) * (x + 2)), ROUND);
        }
    }
}
