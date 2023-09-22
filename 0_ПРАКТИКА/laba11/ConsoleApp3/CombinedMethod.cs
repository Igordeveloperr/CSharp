using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class CombinedMethod
    {
        // макс кол-во итераций при расчетах
        private const int MAX_ITERATIONS = 100;
        // заданная точность вычислений
        private const double E = 0.00001;
        // f(a)
        private double _funcValA;
        // f(b)
        private double _funcValB;
        // f``(a)
        private double _secondDerValA;
        // f``(b)
        private double _secondDerValB;
        // начало интервала
        private double _startOfInterval;
        // конец интервала
        private double _endOfInterval;

        public CombinedMethod(double funcValA, double funcValB, double secondDerValA, double secondDerValB, double startOfInterval, double endOfInterval)
        {
            _funcValA = funcValA;
            _funcValB = funcValB;
            _secondDerValA = secondDerValA;
            _secondDerValB = secondDerValB;
            _startOfInterval = startOfInterval;
            _endOfInterval = endOfInterval;
        }

        // выводим направление вычислений
        public void SelectDirOfCalc()
        {
            if (_funcValA * _secondDerValA > 0)
            {
                Console.WriteLine("Метод касательных по недостатку; Метод хорд по избытку:");
            }
            else if (_funcValB * _secondDerValB > 0)
            {
                Console.WriteLine("Метод касательных по избытку; Метод хорд по недостатку:");
            }
            else
            {
                Logger.LogError("Ошибка! Проверьте корректность функции!");
                throw new ArgumentException("Ошибка! Проверьте корректность функции!");
            }
        }

        // вычисляем значение корня на заданном интервале
        public double CalculateRoot()
        {
            MathFunction function = new MathFunction();
            // значение x0 по недостатку
            double xk = _startOfInterval;
            // значение x0 по избытку
            double xk_ = _endOfInterval;
            // f(xk)
            double fxk;
            // f(xk_)
            double fxk_;
            // | xk - xk_ |
            double difference;

            for (int i = 0; i < MAX_ITERATIONS; i++)
            {
                difference = Math.Abs(xk - xk_);
                fxk = Math.Round(function.Calculate(xk), MathFunction.ROUND);
                fxk_ = Math.Round(function.Calculate(xk_), MathFunction.ROUND);
                xk = Math.Round(xk, MathFunction.ROUND);
                xk_ = Math.Round(xk_, MathFunction.ROUND);
                difference = Math.Round(difference, MathFunction.ROUND);
                Console.WriteLine($"n:{i} ----- xk:{xk} ----- xk_:{xk_} ----- f(xk):{fxk} ----- f(xk_):{fxk_} ----- |xk - xk_|: {difference}");

                // критерий останова
                if (difference < 2 * E) break;

                if (_funcValA * _secondDerValA > 0)
                {
                    xk = xk - fxk / function.CalculateFirstDerivative(xk);
                    xk_ = xk_ - (fxk_ * (xk_ - xk)) / (fxk_ - fxk);
                }
                else if (_funcValB * _secondDerValB > 0)
                {
                    xk = xk - (fxk * (xk_ - xk)) / (fxk_ - fxk);
                    xk_ = xk_ - fxk_ / function.CalculateFirstDerivative(xk_);
                }
                else
                {
                    Logger.LogError("Ошибка! Проверьте корректность функции!");
                    throw new ArgumentException("Ошибка! Проверьте корректность функции!");
                }
            }
            return Math.Round((xk + xk_) / 2, MathFunction.ROUND);
        }
    }
}
