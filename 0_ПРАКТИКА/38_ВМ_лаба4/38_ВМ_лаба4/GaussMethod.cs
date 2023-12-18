using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_ВМ_лаба4
{
    internal class GaussMethod
    {
        double[] x5 = { -0.86114, -0.33998, 0.33998, 0.86114 };
        double[] a5 = { 0.34785, 0.65215, 0.65215, 0.34785 };
        double[] x8 = { -0.949107912, -0.741531186, -0.405845151, 0, 0.405845151, 0.741531186, 0.949107912 };
        double[] a8 = { 0.129484966, 0.279705391, 0.381830051, 0.417959184, 0.381830051, 0.279705391, 0.129484966 };
        private double _a;
        private double _b;

        public GaussMethod(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public double CalcN5Square()
        {
            double sum = 0;
            double xi;
            for (int i = 0; i < x5.Length; i++)
            {
                xi = ((_b + _a) / 2) + ((_b - _a) / 2 * x5[i]);
                sum += a5[i] * CalcFunc(xi);
            }
            return ((_b - _a) / 2) * sum;
        }

        public double CalcN8Square()
        {
            double sum = 0;
            double xi;
            for (int i = 0; i < x8.Length; i++)
            {
                xi = ((_b + _a) / 2) + ((_b - _a) / 2 * x8[i]);
                sum += a8[i] * CalcFunc(xi);
            }
            return ((_b - _a) / 2) * sum;
        }

        private double CalcFunc(double x)
        {
            return (x * x) / Math.Sqrt(x + 1);
        }
    }
}
