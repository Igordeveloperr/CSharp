using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_ВМ_ЛАБА_3
{
    internal class LagInterpolation
    {
        
        private double[,] matrix = new double[6, 8]
        {
            { 0.176, -0.06, -0.12, -0.16, -0.21, -0.29, 0, 0 },
            { 0.06, 0.116, -0.06, -0.1, -0.15, -0.23,  0, 0  },
            { 0.12, 0.06, 0.056, -0.04, -0.09, -0.17, 0, 0  },
            { 0.16, 0.1, 0.04, 0.016, -0.05, -0.13, 0, 0  },
            { 0.21, 0.15, 0.09, 0.05, -0.034, -0.08, 0, 0   },
            { 0.29, 0.23, 0.17, 0.13, 0.08, -0.114, 0, 0  }
        };

        private double MultMatrixString(int num, double[,] arr)
        {
            double res = 1;
            for(int i = 0; i < 6; i++)
            {
                res *= arr[num, i];
            }
            return res;
        }

        private double CalcSumOfYDivD()
        {
            double sum = 0;
            for (int i = 0; i < 6; i++)
            {
                sum += matrix[i, 7];
            }
            return sum;
        }

        private double MultDiagonal()
        {
            double res = 1;
            for(int i = 0; i < 6; i++)
            {
                res *= matrix[i, i];
            }
            return res;
        }

        public LagInterpolation()
        {
            matrix[0, 6] = MultMatrixString(0, matrix);
            matrix[1, 6] = MultMatrixString(1, matrix);
            matrix[2, 6] = MultMatrixString(2, matrix);
            matrix[3, 6] = MultMatrixString(3, matrix);
            matrix[4, 6] = MultMatrixString(4, matrix);
            matrix[5, 6] = MultMatrixString(5, matrix);

            matrix[0, 7] = 2.73951 / MultMatrixString(0, matrix);
            matrix[1, 7] = 2.30080 / MultMatrixString(1, matrix);
            matrix[2, 7] = 1.96864 / MultMatrixString(2, matrix);
            matrix[3, 7] = 1.78776 / MultMatrixString(3, matrix);
            matrix[4, 7] = 1.59502 / MultMatrixString(4, matrix);
            matrix[5, 7] = 1.34310 / MultMatrixString(5, matrix);
        }

        public void PrintTables()
        {
            Console.WriteLine("{0,10}  {1,10}", "X", "Y");
            Console.WriteLine("{0,10}  {1,10}", 0.35, 2.73951);
            Console.WriteLine("{0,10}  {1,10}", 0.41, 2.30080);
            Console.WriteLine("{0,10}  {1,10}", 0.47, 1.96864);
            Console.WriteLine("{0,10}  {1,10}", 0.51, 1.78776);
            Console.WriteLine("{0,10}  {1,10}", 0.56, 1.59502);
            Console.WriteLine("{0,10}  {1,10}", 0.64, 1.34310);

            Console.WriteLine();

            Console.WriteLine("{0,10} {1,10} {2,10} {3,10} {4,10} {5,10}{6,10}{7,10}", "xi-x0", "xi-x1", "xi-x2", "xi-x3", "xi-x4", "xi-x5", "Di", "yi/Di");
            for(int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("{0,10} ", Math.Round(matrix[i, j], 7));
                }
                Console.WriteLine();
            }
            double sum = CalcSumOfYDivD();
            double diagonalP = MultDiagonal();
            double res = sum * diagonalP;
            Console.WriteLine();
            Console.WriteLine($"П = {diagonalP}");
            Console.WriteLine($"S = {sum}");
            Console.WriteLine();
        }

        public double Interpolate(double x)
        {
            return 2.73951 * L1(x) + 2.30080 * L2(x) + 1.96864 * L3(x) + 1.78776 * L4(x) + 1.59502 * L5(x) + 1.34310 * L6(x);
        }

        private double L1(double x)
        {
            return (x-0.41)/(-0.06) * (x-0.47)/(-0.12) * (x-0.51)/(-0.16) * (x-0.56)/(-0.21) * (x-0.64)/(-0.29);
        }

        private double L2(double x)
        {
            return (x - 0.35) / (0.06) * (x - 0.47) / (-0.06) * (x - 0.51) / (-0.1) * (x - 0.56) / (-0.15) * (x - 0.64) / (-0.23);
        }

        private double L3(double x)
        {
            return (x - 0.35) / (0.12) * (x - 0.41) / (0.06) * (x - 0.51) / (-0.04) * (x - 0.56) / (-0.09) * (x - 0.64) / (-0.17);
        }
        private double L4(double x)
        {
            return (x - 0.35) / (0.16) * (x - 0.41) / (0.1) * (x - 0.47) / (0.04) * (x - 0.56) / (-0.05) * (x - 0.64) / (-0.13);
        }
        private double L5(double x)
        {
            return (x - 0.35) / (0.21) * (x - 0.41) / (0.15) * (x - 0.47) / (0.09) * (x - 0.51) / (0.05) * (x - 0.64) / (-0.08);
        }
        private double L6(double x)
        {
            return (x - 0.35) / (0.29) * (x - 0.41) / (0.23) * (x - 0.47) / (0.17) * (x - 0.51) / (0.13) * (x - 0.56) / (0.08);
        }
    }
}
