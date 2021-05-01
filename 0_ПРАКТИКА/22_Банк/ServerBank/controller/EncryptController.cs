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
            RequestObject request = JsonConvert.DeserializeObject<RequestObject>(json);
            RsaEncrypt rsa = new RsaEncrypt();
            ConnectionChannel channel = new ConnectionChannel();
            if(request.Key == null || request.Iv == null)
            {
                string key = rsa.PublicKeyTostring();
                byte[] data = Encoding.UTF8.GetBytes(key);
                channel.SendDataToChannel(data, client);
            }
            else
            {
                
            }
        }
    }
}
