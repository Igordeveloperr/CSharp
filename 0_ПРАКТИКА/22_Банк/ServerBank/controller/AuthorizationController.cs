using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using _22_Банк.model.request;
using _22_Банк.model.request.requests;

namespace ServerBank.controller
{
    internal class AuthorizationController : Controller
    {
        public AuthorizationController()
        {
            ControllerType = RequestType.authorization;
        }
        public override void ControllerStartWork(string json, TcpClient client)
        {
            var channel = new ConnectionChannel();
            channel.SendDataToChannel(Encoding.UTF8.GetBytes("hello"),client);
        }
    }
}
