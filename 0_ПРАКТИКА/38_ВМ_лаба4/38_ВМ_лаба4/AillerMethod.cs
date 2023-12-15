using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_ВМ_лаба4
{
    internal class AillerMethod
    {
        private double _a;
        private double _b;

        public AillerMethod(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public void Calc()
        {
            Console.WriteLine("{0,10}  {1,10}  {2,10}  {3,10}", "x", "y", "f(x,y)", "del(y)");
            double y = 0;
            double yk = 0;
            double del1 = 0;
            double y2 = 0;
            double yk2 = 0;
            double del2 = 0;
            for (double h = _a; h <= _b; h+=0.1)
            {
                del1 = CalcFunc(h, y) * 0.1;
                Console.WriteLine("{0,10}  {1,10}  {2,10}  {3,10}", 
                    Math.Round(h, 5), Math.Round(yk, 5), Math.Round(CalcFunc(h, y), 5), Math.Round(del1, 5));
                yk = y + del1;
                y = yk;
            }

            Console.WriteLine();

            Console.WriteLine("{0,10}  {1,10}  {2,10}  {3,10}", "x+h/2", "y", "f(x,y)", "del(y)");
            for (double h = _a; h <= _b+0.05; h += 0.05)
            {
                del2 = CalcFunc(h, y2) * 0.05;
                Console.WriteLine("{0,10}  {1,10}  {2,10}  {3,10}",
                    Math.Round(h, 5), Math.Round(yk2, 5), Math.Round(CalcFunc(h, y2), 5), Math.Round(del2, 5));
                yk2 = y2 + del2;
                y2 = yk2;
            }
        }

        private double CalcFunc(double x, double y)
        {
            return x * y + Math.Sqrt(x);
        }
    }
}
