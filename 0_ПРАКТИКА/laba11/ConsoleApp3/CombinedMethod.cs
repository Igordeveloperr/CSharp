using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class CombinedMethod
    {
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

        // вычисляем значение корня на заданном интервале
        public double CalculateRoot()
        {
            // значение x0 по недостатку
            double flawX0 = _startOfInterval;
            // значение x0 по избытку
            double excessX0 = _endOfInterval;

            if (_funcValA * _secondDerValA > 0)
            {
                Console.WriteLine("Метод касательных по недостатку; Метод хорд по избытку");
            }
            else if (_funcValB * _secondDerValB > 0)
            {
                Console.WriteLine("Метод касательных по избытку; Метод хорд по недостатку");

            }
            else
            {
                ErrorLogger.PrintError("Ошибка! Проверьте корректность функции!");
                throw new ArgumentException("Ошибка! Проверьте корректность функции!");
            }
        }
    }
}
