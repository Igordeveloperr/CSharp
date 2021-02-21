using _17_ProjectsFinder.Send.Settings;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _17_ProjectsFinder.Send.response
{
    internal class AuthorizationResponse
    {
        private TcpListener listener;
        private NetworkStream Stream;
        private RequestSetting Setting = new RequestSetting();
        public AuthorizationResponse()
        {
            listener = new TcpListener(IPAddress.Parse(Setting.Ip), 8000);
            listener.Start();
        }

        internal async Task<bool> GetAuthorizationResponse()
        {
            TcpClient client = await listener.AcceptTcpClientAsync();
            StringBuilder builder = new StringBuilder();
            byte[] data = new byte[256];
            string result = "";
            Stream = client.GetStream();
            do
            {
                int length = await Stream.ReadAsync(data, 0, data.Length);
                result = builder.Append(Encoding.UTF8.GetString(data, 0, length)).ToString();
            } while (Stream.DataAvailable);
            Stream.Close();
            client.Close();
            return Convert.ToBoolean(result);
        }
    }
}
