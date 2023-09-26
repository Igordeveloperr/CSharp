using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class SIMethod
    {
        // макс кол-во итераций при расчетах
        private const int MAX_ITERATIONS = 100;
        // заданная точность вычислений
        private const double E = 0.00001;
        // начало интервала
        private double _startInterval;
        // конец интервала
        private double _endInterval;
        // ф`(x)
        private double _fi_x;
        // x_k+1
        private double _xk;
        private MathFunction _function;

        public SIMethod(double startInterval, double endInterval)
        {
            _startInterval = startInterval;
            _endInterval = endInterval;
            _function = new MathFunction();
        }

        // вывод служебной инфы
        private void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            string cover = string.Empty;
            string stop_k = string.Empty;
            if (_fi_x > 0)
            {
                cover = "Монотонная сходимость";
                stop_k = "|x - _xk| / (1 - q) <= E";
            }
            else
            {
                cover = "Двусторонняя сходимость";
                stop_k = "|x - _xk| <= E";
            }
            Console.WriteLine(cover);
            Console.WriteLine($"Условие останова: {stop_k}");
            Logger.DrawSeparator();
            Console.ForegroundColor = ConsoleColor.Green;
        }

        // вычисление корня
        public double CalculateRoot()
        {
            bool isCover = CheckConvergence();
            if (isCover)
            {
                return Math.Round(Calculate(), MathFunction.ROUND);
            }
            else
            {
                Logger.LogError("Каноничесий вид функции выбран неверно!");
                throw new ArgumentException();
            }
        }

        // сами вычисления
        private double Calculate()
        {
            double difference;
            double q = SelectMaxValue();
            PrintInfo();
            double x = 0;

            for (int i = 0; i < MAX_ITERATIONS; i++)
            {
                x = _function.CalculateCanon(_xk, _startInterval, _endInterval);
                if (_fi_x > 0)
                {
                    difference = Math.Abs(x - _xk) / (1 - q);
                }
                else
                {
                    difference = Math.Abs(x - _xk);
                }
                // вывод таблицы значений на экран
                Console.WriteLine(
                    "n:{0,10} | xk:{1,10} | x:{2,10} | |x - _xk|:{3,10}",
                    i, _xk, x, Math.Round(Math.Abs(x - _xk), MathFunction.ROUND)
                );
                _xk = x;
                if (difference <= E) break;
            }
            return x;
        }

        // определяем КФ q
        private double SelectMaxValue()
        {
            double fi_a = Math.Abs(_function.CalculateCanonFirstDerivative(_startInterval, _startInterval, _endInterval));
            double fi_b = Math.Abs(_function.CalculateCanonFirstDerivative(_endInterval, _startInterval, _endInterval));
            double max;

            if (fi_a >= fi_b)
            {
                max = fi_a;
            }
            else
            {
                max = fi_b;
            }
            return max;
        }

        // вычисляем середину отрезка
        private double CalculateMidOfSegment()
        {
            return Math.Round((_startInterval + _endInterval) / 2, MathFunction.ROUND);
        }

        // проверка условия сходимости
        private bool CheckConvergence()
        {
            _xk = CalculateMidOfSegment();
            _fi_x = Math.Abs(_function.CalculateCanonFirstDerivative(_xk, _startInterval, _endInterval));
            if (_fi_x < 1)
            {
                //Console.WriteLine("ф`(x) < 1, условие сходимости выполняется");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
