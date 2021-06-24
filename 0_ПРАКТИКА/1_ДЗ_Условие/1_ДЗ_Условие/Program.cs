using System;

namespace _1_ДЗ_Условие
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Введите 3 числа---");
            int input1 = Int32.Parse(Console.ReadLine());
            int input2 = Int32.Parse(Console.ReadLine());
            int input3 = Int32.Parse(Console.ReadLine());
            int output;
            
                
            if (input1 > input2 && input1 > input3)
            {
                output = input1;
                Console.WriteLine("Наибольшее число: " + output);
            }
            else if (input2 > input1 && input2 > input3)
            {
                output = input2;
                Console.WriteLine("Наибольшее число: " + output);
            }
            else
            {
                output = input3;
                Console.WriteLine("Наибольшее число: " + output);
            }

            if(output != null)
            {
                switch (output % 2)
                {
                    case 0:
                        Console.WriteLine("Число четное!");
                        break;
                    default:
                        Console.WriteLine("Число не четное(((");
                        break;
                }

                string str = output < 100 ? "меньше 100" : "Больше 100";
                Console.WriteLine(str);
            }
        }
    }
}
