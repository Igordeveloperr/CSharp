using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_ВМ_ЛАБА_3
{
    internal class KvadratMethod
    {
        double[] x = { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1 };
        double[] y = {1.91, 3.03, 3.98, 4.82, 5.59, 6.31, 7.00, 7.65, 8.27, 8.88};
        public KvadratMethod()
        {
            double x_ar = CalcX_ar();
            double y_ar = CalcY_ar();
            double x_geom = CalcX_geom();
            double y_geom = CalcY_geom();
            double x_garm = CalcX_garm();
            double y_garm = CalcY_garm();
            huata();
        }

        private void huata()
        {
            double sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += Math.Pow((7.5769697 * x[i] + 1.57666666) - y[i], 2);
            }
            Console.WriteLine(sum);
        }

        // арифметическое
        private double CalcX_ar()
        {
            return (0.1 + 1) / 2;
        }

        private double CalcY_ar()
        {
            return (1.91 + 8.88) / 2;
        }

        // геометрическое
        private double CalcX_geom()
        {
            return Math.Sqrt(0.1 * 1);
        }

        private double CalcY_geom()
        {
            return Math.Sqrt(1.91 * 8.88);
        }

        // гармоническое
        private double CalcX_garm()
        {
            return (2*0.1*1)/(0.1+1);
        }
        private double CalcY_garm()
        {
            return (2 * 1.91 * 8.88) / (1.91 + 8.88);
        }
    }
}
