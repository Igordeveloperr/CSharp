using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_ВМ_лаба4
{
    internal class TrapezoidMethod
    {
        const double E = 0.0001;
        private double start;
        private double end;
        private double h;

        public TrapezoidMethod(double a, double b)
        {
            start = a;
            end = b;
            h = E;
        }

        public double CalcSquare()
        {
            //Console.WriteLine("{0,10}  {1,10}  {2,10}", "x", "f(x)", "k");
            double sum = 0;
            sum += 1 / 2 * CalcFunc(start);
<<<<<<< HEAD
         
=======
            //Console.WriteLine("{0,10}  {1,10}  {2,10}", start, Math.Round(CalcFunc(start),5), "1/2");
>>>>>>> 96a2434f84b7f654dc55beb8b9f6f49741288e6c
            for (double i = start+h; i < end; i += h)
            {
                //Console.WriteLine("{0,10}  {1,10}  {2,10}", Math.Round(i,5), Math.Round(CalcFunc(i), 5), "1");
                sum += CalcFunc(i);
            }
            sum += 1 / 2 * CalcFunc(end);
            //Console.WriteLine("{0,10}  {1,10}  {2,10}", end, Math.Round(CalcFunc(end), 5), "1/2");
            return sum * h;
        }

        private double CalcFunc(double x)
        {
            return 1 / Math.Sqrt(x*x+1);
        }

        private double CalcStep()
        {
            return Math.Sqrt(E);
        }
    }
}
