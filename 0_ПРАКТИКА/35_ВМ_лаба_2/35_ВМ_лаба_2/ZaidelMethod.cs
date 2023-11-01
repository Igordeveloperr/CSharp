using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_ВМ_лаба_2
{
    internal class ZaidelMethod
    {
        // точность
        const double E = 0.0001;

        // первый x
        private double CalcX1(double x2_k, double x3_k, double x4_k)
        {
            return (0.21*x2_k + 0.06*x3_k - 0.34*x4_k + 1.42) / 0.76;
        }

        // второй x
        private double CalcX2(double x1, double x3_k, double x4_k)
        {
            return 0.05 * x1 + 0.32 * x3_k + 0.12 * x4_k - 0.57;
        }

        // третий x
        private double CalcX3(double x1, double x4_k)
        {
            return (0.35*x1 - 0.05*x4_k + 0.68) / 1.27;
        }

        // четвертый x
        private double CalcX4(double x1, double x2, double x3)
        {
            return (0.12 * x1 - 0.43 * x2 + 0.34 * x3 - 2.14) / 1.21;
        }

        // макс погрешность
        private double CalcMaxError(double dx1, double dx2, double dx3, double dx4)
        {
            return Math.Max(dx1, Math.Max(dx2, Math.Max(dx3, dx4)));
        }

        // находим корни с заданной точностью
        public void CalcRoot()
        {
            double x1, x2, x3, x4;
            double x1_k = 0, x2_k = 0, x3_k = 0, x4_k = 0;
            double error = 1;

            while (error >= E)
            {
                x1 = CalcX1(x2_k, x3_k, x4_k);
                x2 = CalcX2(x1, x3_k, x4_k);
                x3 = CalcX3(x1, x4_k);
                x4 = CalcX4(x1, x2, x3);

                Console.WriteLine($"x1 = {x1} x2 = {x2} x3 = {x3} x4 = {x4}");
                error = CalcMaxError(x1-x1_k, x2-x2_k, x3 - x3_k, x4 - x4_k);

                x1_k = x1;
                x2_k = x2;
                x3_k = x3;
                x4_k = x4;
            }
        }
    }
}
