using System;
using System.Collections.Generic;

namespace _2_ДЗ_Циклы
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            bool full = true;
            Console.WriteLine("Введите 15 целых чисел: ");
            for (int i = 0; i <= 14; i++)
            {
                string input = Console.ReadLine();
                if (Int32.TryParse(input, out int result))
                {
                    arr.Add(result);

                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Невергый формат!!!");
                    full = false;
                    break;
                }
            }

            if (full)
            {
                int sum = 0;
                for(int i = 0; i < arr.Count; i++)
                {
                    sum += arr[i];
                }
                Console.WriteLine("Сумма всех елементов: " + sum);

                int diff = 0;
                int count = 0;
                while (count < arr.Count)
                {
                    diff -= arr[count];
                    count++;
                }
                Console.WriteLine("Разность всех елементов: " + diff);

                decimal composition = 1;
                int lastCount = 0;
                do
                {
                    composition = composition * Convert.ToDecimal(arr[lastCount]);
                    lastCount++;
                } while (lastCount < arr.Count);
                Console.WriteLine("Произведение всех елементов: " + composition);

                string allElements = "";
                foreach(int elem in arr)
                {
                    allElements += Convert.ToString(elem) + " ";
                }
                Console.WriteLine("Все елементы: " + allElements);
            }
        }
    }
}
