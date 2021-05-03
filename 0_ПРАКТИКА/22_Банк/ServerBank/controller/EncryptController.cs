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
        private static RsaEncrypt rsa = new RsaEncrypt();
        public EncryptController()
        {
            ControllerType = RequestType.encrypt;
        }
        public override void ControllerStartWork(string json, TcpClient client)
        {
            RequestObject request = JsonConvert.DeserializeObject<RequestObject>(json);
            string key = rsa.PublicKeyTostring();
            ConnectionChannel channel = new ConnectionChannel();
            if(request.Key == null || request.Iv == null)
            {
                Console.WriteLine(key);
                byte[] data = Encoding.UTF8.GetBytes(key);
                channel.SendDataToChannel(data, client);
            }
            else
            {   
                var aesKey = rsa.Decrypt(request.Key);
                var iv = rsa.Decrypt(request.Iv);
                var aes = new AesEncrypt(aesKey, iv);
                var encData = aes.DecryptString(request.Data);
                Console.WriteLine(encData);
            }
        }
    }
}
