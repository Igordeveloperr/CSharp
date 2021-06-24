using System;
using System.Collections.Generic;

namespace _2_Шаблоны
{
    class Program
    {
        private static Dictionary<string, Product> command = new Dictionary<string, Product>
        {
            { "яблоко", new Apple() },
            { "хлеб", new Bread() },
            { "груша", new Pear() }
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Введите команду:");
            foreach (var elem in command.Keys)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine("______");
            string input = Console.ReadLine();
            SelectCommand(input);
        }

        private static void SelectCommand(string commandStr)
        {
            if (!string.IsNullOrWhiteSpace(commandStr))
            {
                command[commandStr].PrintInformation();
            }
        }
    }
}
