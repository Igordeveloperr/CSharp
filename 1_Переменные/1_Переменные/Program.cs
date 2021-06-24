using System;

namespace _1_Переменные
{
    class Program
    {
        static void Main(string[] args)
        {   
            // задаю цвет фона в консоли
            Console.BackgroundColor = ConsoleColor.DarkMagenta;

            // инициализирую целочисленную переменную
            int i = 5;
            // переопределяю значение переменной
            i = -13;
            // инициализирую дробную переменную
            double a = 2.4;
            // инициализирую символьную переменную
            char b = 'f';
            // инициализирую логическую переменную
            bool c = true;
            // переопределяю значение логической переменной
            c = false;
            // инициализирую строковую переменную
            string str = "hello c#     ";
            // инициализирую переменную для хранения больших значений
            decimal d = 0.1M;

            Console.WriteLine(str);
        }
    }
}
