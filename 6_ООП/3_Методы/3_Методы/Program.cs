using System;

namespace _3_Методы
{
    class Program
    {
        // объявляю метод
        private static string SayHello(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                return $"hello, {name}!";
            }
            return "bad data!";
        }
        static void Main(string[] args)
        {
            // вызываю описанный метод
            string str = Program.SayHello("C#");
            Console.WriteLine(str);

            
            Person person = new Person("Bob");
            Person person1 = new Person("Alex");
            // проверяю метод класса Person
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(person.Run());
                Console.WriteLine(person1.Run());
            }
            // проверка перегруженного метода
            Console.WriteLine("Override");
            Console.WriteLine(person.Run(1930, 78));
            // фызываю рекурсивную функцию
            Console.WriteLine(person1.GetFactorial(5));
        }
    }
}
