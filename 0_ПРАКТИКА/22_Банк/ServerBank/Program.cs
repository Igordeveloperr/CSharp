using ServerBank.routing;
using System;
using System.Threading;

namespace ServerBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Router r = new Router();
            while (true)
            {
                r.ListenConnectionChannel();
                Thread.Sleep(100);
            }
        }
    }
}
