using _18_exaptionPacush.exceptions;
using System;

namespace _18_exaptionPacush
{
    class Program
    {
        static void Main(string[] args)
        {
            string Host = System.Net.Dns.GetHostName();
            string IP = System.Net.Dns.GetHostByName(Host).AddressList[2].ToString();
            Console.WriteLine(IP);
            try
            {
                string command = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(command)) throw new EmptyStringException("Пустая строка бляяять");
                if (command.Length < 5) throw new SimpleStringException("не существует комманды меньше 5 символов");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
