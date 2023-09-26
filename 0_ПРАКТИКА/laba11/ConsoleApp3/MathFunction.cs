using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class MathFunction
    {
        // мин значение функции
        private const int MIN_VALUE = -1;
        // до куда округляем
        public const byte ROUND = 6;

        // считаем значение функции
        public double Calculate(double x)
        {
            if(x < MIN_VALUE)
            {
                Logger.LogError("D(f) = [-1; +infinity)");
                throw new ArgumentException("D(f) = [-1; +infinity)");
            }
            else
            {
                return Math.Round(x - Math.Sqrt(Math.Log(x + 2)), ROUND);
            }
        }

        // считаем значение 1 производной функции
        public double CalculateFirstDerivative(double x)
        {
            if ((x > -2 && x < -1) || x > -1)
            {
                return Math.Round(1 - 1 / (2 * Math.Log(Math.Sqrt(x + 2)) * (x + 2)), ROUND);
            }
            else
            {
                Logger.LogError("D(f) = (-2; -1) U (-1; +infinity)");
                throw new ArgumentException("D(f) = (-2; -1) U (-1; +infinity)");
            }
        }

        // считаем значение 2 производной функции
        public double CalculateSecondDerivative(double x)
        {
            if ((x > -2 && x < -1) || x > -1)
            {
                return Math.Round(
                    (2*Math.Log(Math.Sqrt(x+2))+1) / (4*Math.Pow(Math.Log(Math.Sqrt(x+2)), 2) * Math.Pow(x+2, 2)), 
                    ROUND);
            }
            else
            {
                Logger.LogError("D(f) = (-2; -1) U (-1; +infinity)");
                throw new ArgumentException("D(f) = (-2; -1) U (-1; +infinity)");
            }
        }

        // вычисление канонической функции
        public double CalculateCanon(double x, double a, double b)
        {
            if (x >= -1)
            {
                return Math.Round(x-Calculate(x)/CalculateK(a,b), ROUND);
            }
            else
            {
                Logger.LogError("D(f) = [-1; +infinity)");
                throw new ArgumentException("D(f) = [-1; +infinity)");
            }
        }

        // вычисление 1 производной канонической функции
        public double CalculateCanonFirstDerivative(double x, double a, double b)
        {
            if ((x > -2 && x < -1) || x > -1)
            {
                return Math.Round(1-CalculateFirstDerivative(x)/CalculateK(a, b), ROUND);
            }
            else
            {
                Logger.LogError("D(f) = (-2; -1) U (-1; +infinity)");
                throw new ArgumentException("D(f) = (-2; -1) U (-1; +infinity)");
            }
        }

        // вычисляем K
        public double CalculateK(double startInterval, double endInterval)
        {
            double f_a = CalculateFirstDerivative(startInterval);
            double f_b = CalculateFirstDerivative(endInterval);
            double N = 0;
            if (f_a >= f_b)
            {
                N = f_a;
            }
            else
            {
                N = f_b;
            }
            
            double k = Math.Abs(N / 2) + 1;
            if (f_a < 0)
            {
                k = k * (-1);
            }
            return k;
        }
    }
}
