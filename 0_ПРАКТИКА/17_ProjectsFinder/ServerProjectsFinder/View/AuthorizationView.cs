using _17_ProjectsFinder.Send.Settings;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerProjectsFinder.View
{
    internal class AuthorizationView
    {
        private RequestSetting Setting = new RequestSetting();
        private NetworkStream Stream;
        public async void SentResultOFAuthorizationToClient(bool result)
        {
            string sendResult = Convert.ToString(result);
            byte[] data = Encoding.UTF8.GetBytes(sendResult);
            TcpClient client = new TcpClient();
            await client.ConnectAsync(Setting.Ip, 8000);
            Stream = client.GetStream();
            Stream.Write(data, 0, data.Length);
            Stream.Close();
            client.Close();
        }
    }
}
