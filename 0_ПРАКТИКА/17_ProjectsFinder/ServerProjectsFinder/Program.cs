using System;
using System.Threading;

namespace ServerProjectsFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Я хочу пиццу!!!!!!");
            }

            Router router = new Router();
            Thread a = new Thread(router.RecivingRequest);
            a.Start();
            Console.ReadLine();
        }
    }
}
