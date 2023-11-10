using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Курсач_бот.logger
{
    internal class InputDataLogger
    {
        public static void Log(string data)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[Входные данные]: '{data}'");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
