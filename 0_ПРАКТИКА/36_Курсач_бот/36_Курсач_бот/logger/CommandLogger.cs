using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Курсач_бот.logger
{
    internal static class CommandLogger
    {
        public static void Log(string data)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"[Пришла команда]: '{data}'");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
