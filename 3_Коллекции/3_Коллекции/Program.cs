using System;
using System.Collections.Generic;

namespace _3_Коллекции
{
    partial class Program
    {
        // перечисление
        private enum Days
        {   
            Mon = 1,
            Tru = 2,
            Wed = 3,
            Tro = 4,
            Fri = 5,
            Sut = 6,
            Sun = 7,
        }
        static void Main(string[] args)
        {
            // создаю массив из 10 чисел, начиная с 0
            int[] array = new int[10];
            // задаю значение 1 и 9 елементу массива
            array[0] = 109;
            array[9] = 10089;
            // 2й вариант создания массива
            int[] arr = {22, 3412, 908};

            Console.WriteLine(array[9]);

            // многомерные массивы
            int[,] doubleArr = new int[10, 3];
            doubleArr[0, 1] = 90;
            Console.WriteLine(doubleArr[0, 1]);

            // создаю список
            List<int> list = new List<int>();
            // добавляю елемент в список
            list.Add(289);
            Console.WriteLine(list[0]);
            // 2й способ создания списка
            List<int> list2 = new List<int>()
            {
                122, 343, 899, 0990, 2121
            };

            // обращаюсь к перечислению
            Console.WriteLine(Days.Mon);
        }
    }
}
