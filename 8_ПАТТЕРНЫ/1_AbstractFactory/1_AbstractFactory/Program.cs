using _1_AbstractFactory.factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client1 client = new Client1(new GokhliaFactory());
            client.Run();
            Client1 client1 = new Client1(new ArduinoFactory());
            client1.Run();
            Client1 client2 = new Client1(new IskraFactory());
            client2.Run();
            Console.ReadLine();
        }
    }
}
