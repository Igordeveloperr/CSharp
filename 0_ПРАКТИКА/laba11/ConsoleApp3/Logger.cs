using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal static class Logger
    {
        private const string SEPARATOR = "----------------------------";

        // рисуем разделительную линию
        public static void DrawSeparator()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(SEPARATOR);
            Console.ForegroundColor = ConsoleColor.Green;
        }

        // логирование ошибок
        public static void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Green;
        }
    }
}
