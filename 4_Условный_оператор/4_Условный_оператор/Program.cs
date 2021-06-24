using System;

namespace _4_Условный_оператор
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int i = Int32.Parse(Console.ReadLine());
            // условный оператор
            if (i <= 50)
            {
                Console.WriteLine("Фейспам чеел, ты в мутеее!!!");
            }
            else
            {
                Console.WriteLine("Тюююю пошел отсюда!!!");
            }

            // двойное условие
            if(i < 10 && i > 0)
            {
                Console.WriteLine("Тыыыы еще ребенооок, воон отсюда!!!");
            }
            else if (i < 100)
            {
                Console.WriteLine("Ну ты модный");
            }

            // сравнение строк
            string str = "Привет";
            // StringComparison.OrdinalIgnoreCase - игнорирует регистр
            if (str.Equals("привет", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("нуу привет!");
            }

            // еще один тип условного оператора
            Console.Write("Число от 0 до 2: ");
            int input = Int32.Parse(Console.ReadLine());
            switch (input)
            {
                case 0:
                    Console.WriteLine("Ну ноль да ии");
                    break;
                case 1:
                    Console.WriteLine("Ну 1 да ии");
                    break;
                case 2:
                    Console.WriteLine("Ну 2 да ии");
                    break;
            }
        }
    }
}
