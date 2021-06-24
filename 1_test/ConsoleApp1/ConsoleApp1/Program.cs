using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("write number: ");
            double a = Double.Parse(Console.ReadLine());

            Console.Write("write number 2: ");
            double b = Double.Parse(Console.ReadLine());

            Console.WriteLine(a + b);
        }
    }
}
