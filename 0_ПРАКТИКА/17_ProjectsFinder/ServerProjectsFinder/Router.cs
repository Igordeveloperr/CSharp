using ServerProjectsFinder.conf;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace ServerProjectsFinder
{
    class Router : IRouter
    {
        private string Json;
        private TcpListener listener;
        public byte[] Data { get; } = new byte[1024];
        private NetworkStream Stream;
        public IRouterSetting Setting { get; } = new RouterSetting();
        public Router()
        {
            listener = new TcpListener(IPAddress.Parse(Setting.Ip), Setting.Port);
            listener.Start();
        }
        public async void RecivingRequest()
        { 
            TcpClient client = await listener.AcceptTcpClientAsync();
            Stream = client.GetStream();
            if (Stream.CanRead)
            {
                StringBuilder builder = new StringBuilder();
                do
                {
                    int a = Stream.Read(Data, 0, Data.Length);
                    builder.Append(Encoding.UTF8.GetString(Data, 0, a));
                    Console.WriteLine(builder.ToString());
                }
                while (Stream.DataAvailable);
            }
            //var obj = JsonSerializer.Deserialize<IRequest>(Json);
            Stream.Close();
            client.Close();
        }
    }
}
