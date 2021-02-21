using System;
using System.Threading;

namespace ServerProjectsFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Router router = new Router();
            Thread a = new Thread(router.RecivingRequest);
            a.Start();
            Console.ReadLine();
        }
    }
}
