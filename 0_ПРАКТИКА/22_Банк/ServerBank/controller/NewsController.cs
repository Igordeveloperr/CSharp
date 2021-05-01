using _22_Банк.model.request.requests;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace ServerBank.controller
{
    internal class NewsController : Controller
    {
        public NewsController()
        {
            ControllerType = RequestType.news;
        }
        public override void ControllerStartWork(string json, TcpClient client)
        {
            throw new NotImplementedException();
        }
    }
}
