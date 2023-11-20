using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_ВМ_ЛАБА_3
{
    internal class NewtonInterpolation
    {
        private const double a0 = 0.860708;
        private const double h = 0.05;

        List<double> AMass = new List<double>(10) { 0,0,0,0,0,0,0,0,0,0};

        private double[,] table = new double[11, 12]
        {
            { 0.15, 0.860708, -0.041977, 0.002047, -0.0001, 0.000006, -0.000003, 0.000005, -0.000007, 0.000006, 0.000005, -0.000041 },
            { 0.20, 0.818731, -0.03993, 0.001947, -0.000094, 0.000003, 0.000002, -0.000002, -0.000001, 0.000011, -0.000036, 0 },
            { 0.25, 0.778801, -0.037983, 0.001853, -0.000091, 0.000005, 0,       -0.000003, 0.00001,  -0.000025, 0, 0 },
            { 0.30, 0.740818, -0.03613, 0.001762, -0.000086, 0.000005, -0.000003, 0.000007, -0.000015, 0, 0, 0 },
            { 0.35, 0.704688, -0.034368, 0.001676, -0.000081, 0.000002, 0.000004, -0.000008, 0, 0, 0, 0 },
            { 0.40, 0.670320, -0.032692, 0.001595, -0.000079, 0.000006, -0.000004, 0, 0, 0, 0, 0 },
            { 0.45, 0.637628, -0.031097, 0.001516, -0.000073, 0.000002, 0, 0, 0, 0, 0, 0 },
            { 0.50, 0.606531, -0.029581, 0.001443, -0.000071, 0, 0, 0, 0, 0, 0, 0 },
            { 0.55, 0.576950, -0.028138, 0.001372, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0.60, 0.548812, -0.026766, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0.65, 0.522046, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        };

        public NewtonInterpolation()
        {
            DrawTable();
            CalcA();
        }

        public double CalcPolinom(double x)
        {
            double s1 = AMass[0] * (x - 0.15);
            double s2 = AMass[1] * (x - 0.15) * (x - 0.20);
            double s3 = AMass[2] * (x - 0.15) * (x - 0.20) * (x - 0.25);
            double s4 = AMass[3] * (x - 0.15) * (x - 0.20) * (x - 0.25) * (x - 0.30);
            double s5 = AMass[4] * (x - 0.15) * (x - 0.20) * (x - 0.25) * (x - 0.30) * (x - 0.35);
            double s6 = AMass[5] * (x - 0.15) * (x - 0.20) * (x - 0.25) * (x - 0.30) * (x - 0.35) * (x - 0.40);
            double s7 = AMass[6] * (x - 0.15) * (x - 0.20) * (x - 0.25) * (x - 0.30) * (x - 0.35) * (x - 0.40) * (x - 0.45);
            double s8 = AMass[7] * (x - 0.15) * (x - 0.20) * (x - 0.25) * (x - 0.30) * (x - 0.35) * (x - 0.40) * (x - 0.45) * (x - 0.50);
            double s9 = AMass[8] * (x - 0.15) * (x - 0.20) * (x - 0.25) * (x - 0.30) * (x - 0.35) * (x - 0.40) * (x - 0.45) * (x - 0.50) * (x - 0.55);
            double s10 = AMass[9] * (x - 0.15) * (x - 0.20) * (x - 0.25) * (x - 0.30) * (x - 0.35) * (x - 0.40) * (x - 0.45) * (x - 0.50) * (x - 0.55) * (x - 0.60);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            Console.WriteLine(s8);
            Console.WriteLine(s9);
            Console.WriteLine(s10);
            Console.WriteLine();

            return a0 + AMass[0]*(x-0.15) + AMass[1] * (x - 0.15)*(x-0.20) + AMass[2] * (x - 0.15) * (x - 0.20) * (x - 0.25) +
                AMass[3] * (x - 0.15) * (x - 0.20) * (x - 0.25) * (x - 0.30) + AMass[4] * (x - 0.15) * (x - 0.20) * (x - 0.25) * (x - 0.30)*(x-0.35)+
                AMass[5] * (x - 0.15) * (x - 0.20) * (x - 0.25) * (x - 0.30) * (x - 0.35)*(x-0.40)+
                AMass[6] * (x - 0.15) * (x - 0.20) * (x - 0.25) * (x - 0.30) * (x - 0.35) * (x - 0.40)*(x-0.45)+
                AMass[7] * (x - 0.15) * (x - 0.20) * (x - 0.25) * (x - 0.30) * (x - 0.35) * (x - 0.40) * (x - 0.45)*(x-0.50)+
                AMass[8] * (x - 0.15) * (x - 0.20) * (x - 0.25) * (x - 0.30) * (x - 0.35) * (x - 0.40) * (x - 0.45) * (x - 0.50) *(x-0.55)+
                AMass[9] * (x - 0.15) * (x - 0.20) * (x - 0.25) * (x - 0.30) * (x - 0.35) * (x - 0.40) * (x - 0.45) * (x - 0.50) * (x - 0.55) * (x-0.60);
        }

        private void CalcA()
        {
            for (int i = 2; i < 12; i++)
            {
                AMass[i - 2] = table[0, i] / (Factorial(i-1)*Math.Pow(h,i-1));
            }
        }

        private long Factorial(int n)
        {
            long res = 1;
            for (int i = 2; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }

        private void DrawTable()
        {
            Console.WriteLine("{0,11}{1,11}{2,11}{3,11}{4,11}{5,11}{6,11}{7,11}{8,11}{9,11}{10,11}{11,11}",
                "X", "Y", "del Y", "del^2 Y", "del^3 Y", "del^4 Y", "del^5 Y", "del^6 Y", "del^7 Y", "del^8 Y", "del^9 Y", "del^10 Y");
            Console.WriteLine();
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Console.Write("{0,11}", table[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
