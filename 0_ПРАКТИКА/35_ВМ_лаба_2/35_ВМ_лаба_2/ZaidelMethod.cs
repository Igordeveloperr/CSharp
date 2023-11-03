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
        private double[,] _arrayofKf;
        private Matrix _canonMatrix;

        public ZaidelMethod()
        {
            _arrayofKf = new double[4, 4]
            {
                { -0.76,0.21,0.06,-0.34 },
                { 0.05,-1,0.32,0.12 },
                { 0.35,0,-1.27,0.05 },
                { 0.12,-0.43,0.34,-1.21 }
            };
            _canonMatrix = new Matrix(4,4);
            _canonMatrix.Fill(_arrayofKf);
        }

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
            double x1 = 0, x2 = 0, x3 = 0, x4 = 0;
            double x1_k = 0, x2_k = 0, x3_k = 0, x4_k = 0;
            double error = 1;

            while (error >= E)
            {
                x1 = CalcX1(x2_k, x3_k, x4_k);
                x2 = CalcX2(x1, x3_k, x4_k);
                x3 = CalcX3(x1, x4_k);
                x4 = CalcX4(x1, x2, x3);

                error = CalcMaxError(x1-x1_k, x2-x2_k, x3 - x3_k, x4 - x4_k);
                Console.WriteLine($"x1 = {x1} x2 = {x2} x3 = {x3} x4 = {x4} error = {error}");

                x1_k = x1;
                x2_k = x2;
                x3_k = x3;
                x4_k = x4;
            }
            x1 = Math.Round(x1, 5);
            x2 = Math.Round(x2, 5);
            x3 = Math.Round(x3, 5);
            x4 = Math.Round(x4, 5);
            Console.WriteLine($"Ответ: x1 = {x1} x2 = {x2} x3 = {x3} x4 = {x4}");
        }

        public void PrintConvergenceConditions()
        {
            Console.WriteLine("МЕТОД ЗЕЙДЕЛЯ");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Матрица коэффициентов:");
            for (int i = 0; i < _canonMatrix.Row; i++)
            {
                for(int j = 0; j < _canonMatrix.Column; j++)
                {
                    Console.Write(" {0,5} ", _canonMatrix.array[i,j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Условия сходимости:");
            for (int i = 0; i < _canonMatrix.Row; i++)
            {
                Console.Write($"|{_canonMatrix.array[i,i]}| > ");
                for (int j = 0; j < _canonMatrix.Column; j++)
                {
                    if (j != i && j != _canonMatrix.Column - 1)
                    {
                        Console.Write($"|{_canonMatrix.array[i, j]}| + ");
                    }
                    else if(j != i && j == _canonMatrix.Column - 1)
                    {
                        Console.Write($"|{_canonMatrix.array[i, j]}|");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Решение:");
        }
    }
}
