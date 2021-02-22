using System;
using System.Threading;

namespace ServerProjectsFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Router router = new Router();
            while (true)
            {   
                router.RecivingRequest();
                Thread.Sleep(1000);
            }
        }
    }
}
