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
                var selecter =  new ControllerSelecter(data, client);
                selecter.SelectController();
                selecter.StartSelectedController();
                Thread.Sleep(100);
            }
        }
    }
}
