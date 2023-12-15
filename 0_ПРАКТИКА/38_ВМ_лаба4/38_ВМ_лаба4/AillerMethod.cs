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
            Console.WriteLine("{0,10}  {1,10}  {2,10}  {3,10}  {4,10}  {5,10}", "x", "y", "f(x,y)", "del(y)", "y-точное", "E");
            double yk = 0.2;
            double y = 0.2;
            double dely = 0;

            for (double h = _a; h <= _b; h+=0.1)
            {
                dely = CalcFunc(h, y) * 0.1;
                yk = y + dely;
                y = yk;
                Console.WriteLine("{0,10}  {1,10}  {2,10}  {3,10}   {4,10}  {5,10}", 
                    Math.Round(h, 5), Math.Round(y, 5), Math.Round(CalcFunc(h, y),5), Math.Round(dely, 5),
                    Math.Round(F(h),5), Math.Abs(Math.Round(F(h)-y,5)));
            }
        }

        private double CalcFunc(double x, double y)
        {
            return 2 * x * x + 3 * y;
        }

        private double F(double x)
        {
            return 0.348148 * Math.Pow(Math.E, 3 * x) - 0.444444 * x - 0.666667 * x * x - 0.148148;
        }
    }
}
