using _22_Банк.encrypt;
using _22_Банк.model.request;
using _22_Банк.model.request.requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace ServerBank.controller
{
    internal class EncryptController : Controller
    {
        public EncryptController()
        {
            ControllerType = RequestType.encrypt;
        }
        public override void ControllerStartWork(string json, TcpClient client)
        {

        }
    }
}
