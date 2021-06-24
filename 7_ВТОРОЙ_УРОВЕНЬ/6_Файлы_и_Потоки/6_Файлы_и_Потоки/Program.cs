using System;
using System.IO;
using System.Text;

namespace _6_Файлы_и_Потоки
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            /*
                Алгоритм работы с файлом:
                1) Открыть
                2) Прочитать / Записать
                3) Закрыть
             */
            // позволяет создать объект, который будет доступен в рамках данной конструкции
            using (var sw = new StreamWriter("../TextFile1.txt", true, Encoding.UTF8))
            {   
                // начинаю запись файла
                sw.Write("Привет зяблики!");
                sw.WriteLine("До связи...");
            }

            // чтение файла
            using (var sr = new StreamReader("../TextFile1.txt", Encoding.UTF8))
            {
                string resText = "";
                // построчное чтение файла
                while (!sr.EndOfStream)
                {
                    resText += sr.ReadLine() + " ^+";
                }
                Console.WriteLine(resText);
                Console.WriteLine("--------------------");
                
                // моментальное чтение
                string text = sr.ReadToEnd();
                Console.WriteLine(text);
            }
        }
    }
}
