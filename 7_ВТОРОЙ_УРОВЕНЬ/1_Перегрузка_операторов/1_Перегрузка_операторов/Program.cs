using System;

namespace _1_Перегрузка_операторов
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple("Красное яблоко", 52, 100);
            Apple apple2 = new Apple("Зеленое яблоко", 34, 100);

            Apple sumApple = Apple.Add(apple, apple2);
            // использую перегруженный оператор сложения
            Apple sumApple2 = apple + apple2;
            Console.WriteLine(sumApple);
            Console.WriteLine(sumApple2);
            Console.WriteLine(sumApple + sumApple2);

            // проверяю перегруженные логические операторы
            Console.WriteLine($"Объем яблок одинаковый: {apple == apple2}");
            Console.WriteLine($"Объем яблок разный: {apple != apple2}");
        }
    }
}
