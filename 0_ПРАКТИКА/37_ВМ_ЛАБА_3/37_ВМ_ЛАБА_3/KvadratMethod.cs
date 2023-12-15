using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_ВМ_ЛАБА_3
{
    internal class KvadratMethod
    {
        double sum_xi_2;
        double sum_xi;
        double sum_xi_yi;
        double sum_yi;
        double[] x = { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1 };
        double[] y = {1.91, 3.03, 3.98, 4.82, 5.59, 6.31, 7.00, 7.65, 8.27, 8.88};
        double[] lnX = new double[10];
        double[] lnY = new double[10];
        public KvadratMethod()
        {
            
            CalcLnX();
            CalcLnY();
            CalcSumXi2();
            CalcSumXi();
            CalcSumXiYi();
            CalcSumYi();
        }

        public void PrintTable()
        {
            double sum=0;
            Console.WriteLine("X = ln x");
            Console.WriteLine("Y = ln y");
            Console.WriteLine();
            Console.WriteLine("{0,9}  {1,9}  {2,9}  {3,9}  {4,9}  {5,9}  {6,9}  {7,9}  {8,9}  {9,9}",
           "i", "X", "Y", "X*Y", "(X)^2", "y^T", "del", "del^2", "x", "y");
            for (int i = 0; i < x.Length; i++)
            {
                double del = Math.Abs(y[i] - CalcFunc(x[i]));
                sum += del * del;
                Console.WriteLine("{0,9}  {1,9}  {2,9}  {3,9}  {4,9}  {5,9}  {6,9}  {7,9}  {8,9}  {9,9}",
                    i, Math.Round(lnX[i],5), Math.Round(lnY[i],5), Math.Round(lnX[i] * lnY[i],5), Math.Round(lnX[i]*lnX[i],5), Math.Round(CalcFunc(x[i]),3),
                    Math.Round(del, 5), Math.Round(del * del, 5), x[i], y[i]);
            }
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine("{0,7}   {1,7}      {2,7}   {3,7}    {4,7}{5,7}  {6,7}  {7,7}",
            "Sum", $"{Math.Round(sum_xi,2)}", $"{Math.Round(sum_yi,2)}", $"{Math.Round(sum_xi_yi,5)}", $"{Math.Round(sum_xi_2,5)}", "", "", $"{Math.Round(sum, 5)}");
        }

        public void SKO()
        {
            double sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += Math.Pow(y[i] - CalcFunc(x[i]), 2);
            }
            Console.WriteLine($"СКО = {Math.Sqrt(sum) / 10}");
        }

        private void CalcLnY()
        {
            for (int i = 0; i < y.Length; i++)
            {
                lnY[i] = Math.Log(y[i]);
            }
        }

        private void CalcLnX()
        {
            for (int i = 0; i < x.Length; i++)
            {
                lnX[i] = Math.Log(x[i]);
            }
        }

        private void CalcSumYi()
        {
            for (int i = 0; i < lnY.Length; i++)
            {
                sum_yi += lnY[i];
            }
        }

        private void CalcSumXiYi()
        {
            for (int i = 0; i < lnX.Length; i++)
            {
                sum_xi_yi += lnX[i] * lnY[i];
            }
        }

        private void CalcSumXi()
        {
            for (int i = 0; i < lnX.Length; i++)
            {
                sum_xi += lnX[i];
            }
        }

        private void CalcSumXi2()
        {
            for (int i = 0; i < lnX.Length; i++)
            {
                sum_xi_2 += Math.Pow(lnX[i], 2);
            }
        }

        private double CalcFunc(double x)
        {
            return 8.8771963612802 * Math.Pow(x, 0.667119338850096);
        }
    }
}
