using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices.ComTypes;

namespace _5_циклы
{
    class Program
    {
        static void Main(string[] args)
        {
            // цикл for
            for(int i = 0; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }

            // заполнение списка списка циклом
            var list = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                list.Add(i);
            }

            // перебор списка циклом
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            // цикл while
            var list2 = new List<string>();
            while(list2.Count < 3)
            {
                list2.Add(Console.ReadLine());
            }

            // перебор списка
            int count = 0;
            while(count < list2.Count)
            {
                Console.WriteLine("-----------");
                Console.WriteLine(list2[count]);
                count++;
            }

            // цикл do-while
            int iter = 0;
            do
            {
                Console.WriteLine("Count = " + iter);
                iter += 2;
            }
            while (iter < 2);

            // цикл foreach
            int[] nums = {1,2,3,4,5};
            foreach(int elem in nums)
            {
                Console.WriteLine("- - -");
                Console.WriteLine(elem);
                Console.WriteLine("- - -");
            }

            // команды break и continue
            for(int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    // переход на следующую итерацию цикла
                    continue;
                }
                Console.WriteLine("-*-*-");
                Console.WriteLine(i);
                Console.WriteLine("-*-*-");
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("-:-:-");
                Console.WriteLine(i);
                Console.WriteLine("-:-:-");
                if (i == 2)
                {
                    // выход из цикла
                    break;
                }
            }
        }
    }
}
