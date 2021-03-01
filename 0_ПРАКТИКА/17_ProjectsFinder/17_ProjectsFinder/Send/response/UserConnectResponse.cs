using _17_ProjectsFinder.Send.Settings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _17_ProjectsFinder.Send.response
{
    internal class UserConnectResponse
    {
        private RequestSetting Setting = new RequestSetting();
        public async Task<string> GetResponse()
        {
            string result = "";
            byte[] data = new byte[256];
            try
            {
                TcpListener listener = new TcpListener(IPAddress.Parse(Setting.Ip), 4343);
                listener.Start();
                TcpClient client = await listener.AcceptTcpClientAsync();
                NetworkStream stream = client.GetStream();
                if (stream.CanRead)
                {
                    do
                    {
                        int count = await stream.ReadAsync(data, 0, data.Length);
                        result = Encoding.UTF8.GetString(data, 0, count);
                    }
                    while (stream.DataAvailable);
                    stream.Close();
                    client.Close();
                    listener.Stop();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }
    }
}
