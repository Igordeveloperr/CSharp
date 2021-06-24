using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using _22_Банк.encrypt;
using _22_Банк.model.request;
using _22_Банк.model.request.requests;
using Newtonsoft.Json;
using ServerBank.db;
using ServerBank.db.entities;

namespace ServerBank.controller
{
    internal class AuthorizationController : Controller
    {
        private static RsaEncrypt rsa = new RsaEncrypt();
        public AuthorizationController()
        {
            ControllerType = RequestType.authorization;
        }
        public override void ControllerStartWork(string json, TcpClient client)
        {
            RequestObject request = JsonConvert.DeserializeObject<RequestObject>(json);
            string key = rsa.PublicKeyTostring();
            ConnectionChannel channel = new ConnectionChannel();
            if (request.Key == null || request.Iv == null)
            {
                byte[] data = Encoding.UTF8.GetBytes(key);
                channel.SendDataToChannel(data, client);
            }
            else
            {
                var aesKey = rsa.Decrypt(request.Key);
                var iv = rsa.Decrypt(request.Iv);
                var aes = new AesEncrypt(aesKey, iv);
                var encData = aes.DecryptString(request.Data);
                using (UserContext db = new UserContext())
                {
                    var user = new User { Name = "test", Password = "1" };
                    var a = db.Users;
                    a.Add(user);
                    Console.WriteLine(11111111111111);
                }
            }
        }
    }
}
