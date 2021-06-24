using System;

namespace _2_Приведение_преобразование_типов
{
    class Program
    {
        static void Main(string[] args)
        {
            // явное приведение типов
            int i = 9;
            byte c = (byte) i;
            // не явное приведение типов
            byte h = 252;
            int d = h;
            // явное преобразование типов
            string year = "2020";
            // конвертирую строку в целочисленное значение
            int nowYear = Convert.ToInt32(year);
            // 2й способ конвертации
            nowYear = Int32.Parse(year);
            Console.WriteLine(nowYear.GetType());
            // 3й способ конвертации !!!САМЫЙ ЛУЧШИЙ СПОСОБ
            if(Int32.TryParse("145", out int result))
            {
                Console.WriteLine(result.GetType());
            }
            // не явное преобразование
            int y = 98;
            /* 
             * в данной ситуации компилятор сам понимает, 
             * что y надо преобразовать в строку
             */
            string str = "coordinat y: " + y;
            Console.WriteLine(str);
        }
    }
}
