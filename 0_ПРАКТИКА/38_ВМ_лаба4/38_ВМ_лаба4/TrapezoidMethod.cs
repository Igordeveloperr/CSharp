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
            double sum = 0;
            sum += 1 / 2 * CalcFunc(start);
            for (double i = start+h; i < end; i += h)
            {
                sum += CalcFunc(i);
            }
            sum += 1 / 2 * CalcFunc(end);
            return sum * h;
        }

        private double CalcFunc(double x)
        {
            return Math.Tan(x*x) / (x*x + 1);
        }

        private double CalcStep()
        {
            return Math.Sqrt(E);
        }
    }
}
