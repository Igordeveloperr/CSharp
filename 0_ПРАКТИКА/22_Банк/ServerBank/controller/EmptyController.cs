using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace ServerBank.controller
{
    internal class EmptyController : Controller
    {
        public override void ControllerStartWork(string json, TcpClient client)
        {
            Console.WriteLine("пустой запрос");
        }
    }
}
