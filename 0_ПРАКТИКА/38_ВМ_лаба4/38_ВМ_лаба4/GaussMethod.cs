using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_ВМ_лаба4
{
    internal class GaussMethod
    {
        double[] x5 = { -0.90618, -0.538469, 0, 0.538469, 0.90618 };
        double[] a5 = { 0.23698, 0.47863, 0.56889, 0.47863, 0.23698 };
        double[] x8 = { -0.96028986, -0.79666648, -0.52553242, -0.18343464, 0.18343464, 0.52553242, 0.79666648, 0.96028986 };
        double[] a8 = { 0.10122854, 0.22238103, 0.31370664, 0.36268378, 0.36268378, 0.31370664, 0.22238103, 0.10122854 };
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
            return (x * x + 0.5) / Math.Sqrt(x * x + 1);
        }
    }
}
