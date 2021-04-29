using ServerBank.controller;
using ServerBank.routing;
using System;
using System.Net.Sockets;
using System.Threading;

namespace ServerBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Router router = new Router();
            while (true)
            {
                TcpClient client = router.ConnectClientToChannel().Result;
                string data = router.GetDataFromConnectionChannel(client);
                Console.WriteLine(data);
                new ControllerSelecter(data).SelectController();
                router.CloseConnectionChannel(client);
                Thread.Sleep(100);
            }
        }
    }
}
