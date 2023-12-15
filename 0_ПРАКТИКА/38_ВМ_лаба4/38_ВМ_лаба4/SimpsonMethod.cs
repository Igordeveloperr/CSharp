using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_ВМ_лаба4
{
    internal class SimpsonMethod
    {
        private double start;
        private double end;
        private double h;
        private int len;
        public SimpsonMethod(double a, double b, int n)
        {
            start = a;
            end = b;
            len = n;
            h = CalcStep(a,b,n);
        }

        public double CalcSquare()
        {
            int count = 1;
            double sum = 0;
            double kf = 4;
            sum += CalcFunc(start);
            for (double i = start+h; i < end; i += h)
            {
                if(count % 2 == 0)
                {
                    kf = 2;
                }
                else
                {
                    kf = 4;
                }
                sum += kf*CalcFunc(i);
                count++;
            }
            sum += CalcFunc(end);
            return sum*(h/3);
        }

        private double CalcFunc(double x)
        {
            return 1 / Math.Sqrt(2*x*x+1.3);
        }

        private double CalcStep(double a, double b, int n)
        {
            return (b - a) / n;
        }
    }
}
