using System;
using System.Collections.Generic;
using _10_filehelper.command;

namespace _10_filehelper
{    
    class Program
    {
        private static Dictionary<string, Command> Commands = new Dictionary<string, Command>
        {
            {"nf", new NewFile() },
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Бихнете каманду:");
            foreach(var cmd in Commands.Keys)
            {
                Console.WriteLine($" - {cmd}");
            }
            string command = Console.ReadLine();
            SelectCommand(command);
        }

        public static void SelectCommand(string cmd)
        {
            Commands[cmd].CallCommand();
        }
    }
}
