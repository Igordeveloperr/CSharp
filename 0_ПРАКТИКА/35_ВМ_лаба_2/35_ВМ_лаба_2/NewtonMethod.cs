using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_ВМ_лаба_2
{
    internal class NewtonMethod
    {
        private const double E = 0.001;
        private double delX = 0;
        private double delY = 0;

        public NewtonMethod()
        {

        }
        
        public void PrintInfo()
        {
            Console.WriteLine("МЕТОД НЬЮТОНА");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Исходная система:");
            Console.WriteLine("sin(x + 2.1)-3*y+0.4 = 0");
            Console.WriteLine("cos(y + 1.8)+1.2*x = 0");
            Console.WriteLine("Таблица:");
        }

        // калькулируем
        public void CalcRoot()
        {
            double error = 1;
            double x = 1, y = 1;
            int i = 0;
            Console.WriteLine("      n             x                  y                  delX                  delY                  err");
            while (error >= E)
            {
                CalcResiduals(x, y);
                error = GetMaxResid();
                x = x + delX;
                y = y + delY;
                Console.WriteLine("{0,7} | {1,7} | {2,7} | {3,7} | {4,7} | {5,7}",
                    i, x, y, delX, delY, error);
                i++;
            }

            x = Math.Round(x, 4);
            y = Math.Round(y, 4);
            Console.WriteLine($"Ответ: x = {x} y = {y}");
        }

        private double GetMaxResid()
        {
            return Math.Max(delX*delX, delY*delY);
        }

        // первая функция
        private double F1(double x, double y)
        {
            return Math.Sin(x+2.1)-3*y+0.4;
        }

        private double F1_x(double x)
        {
            return Math.Cos(x+2.1);
        }

        private double F1_y()
        {
            return -3;
        }

        // вторая функция
        private double F2(double x, double y)
        {
            return Math.Cos(y + 1.8) + 1.2 * x;
        }

        private double F2_x()
        {
            return 1.2;
        }

        private double F2_y(double y)
        {
            return -Math.Sin(y+1.8);
        }

        //рассчет невязок
        private void CalcResiduals(double x, double y)
        {
            Matrix A = new Matrix(2,2);
            A.array[0, 0] = F1_x(x);
            A.array[0, 1] = F1_y();
            A.array[1, 0] = F2_x();
            A.array[1, 1] = F2_y(y);
                        
            Matrix B = new Matrix(2, 1);
            B.array[0, 0] = -F1(x, y);
            B.array[1, 0] = -F2(x, y);

            double detA = A.Determinant();
            Matrix ATransponse = A.Transpose();
            double a11 = ATransponse.array[1, 1];
            double a12 = -1*ATransponse.array[0, 1];
            double a21 = -1*ATransponse.array[1, 0];
            double a22 = ATransponse.array[0, 0];
            Matrix AlgDop = new Matrix(2, 2);
            AlgDop.array[0, 0] = a11;
            AlgDop.array[0, 1] = a12;
            AlgDop.array[1, 0] = a21;
            AlgDop.array[1, 1] = a22;
            Matrix inverseMatrix = (AlgDop * (1 / detA)).Transpose();

            Matrix X = inverseMatrix * B;
            delX = X.array[0, 0];
            delY = X.array[1, 0];
        }
    }
}
