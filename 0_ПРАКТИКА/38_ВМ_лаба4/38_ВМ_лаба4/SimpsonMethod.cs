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
        }

        public double CalcSquare()
        {
            h = 0.01;
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

        public double CalcSquareWithHDiv2()
        {
            h = CalcStep(start, end, len);
            int count = 1;
            double sum = 0;
            double kf = 4;
            sum += CalcFunc(start);
            for (double i = start + h; i < end; i += h)
            {
                if (count % 2 == 0)
                {
                    kf = 2;
                }
                else
                {
                    kf = 4;
                }
                sum += kf * CalcFunc(i);
                count++;
            }
            sum += CalcFunc(end);
            return sum * (h / 3);
        }

        private double CalcFunc(double x)
        {
            return (Math.Cos(x)/(x+1));
        }

        private double CalcStep(double a, double b, int n)
        {
            return (b - a) / n;
        }
    }
}
