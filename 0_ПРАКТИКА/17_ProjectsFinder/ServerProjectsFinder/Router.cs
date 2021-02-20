using ServerProjectsFinder.conf;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using _17_ProjectsFinder.Send;


namespace ServerProjectsFinder
{
    class Router : IRouter
    {
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
            string json = "";
            TcpClient client = await listener.AcceptTcpClientAsync();
            Stream = client.GetStream();
            if (Stream.CanRead)
            {
                StringBuilder builder = new StringBuilder();
                do
                {
                    int count = Stream.Read(Data, 0, Data.Length);
                    json = builder.Append(Encoding.UTF8.GetString(Data, 0, count)).ToString();
                }
                while (Stream.DataAvailable);
                SelectController(json);
            }
            Stream.Close();
            client.Close();
        }

        private void SelectController(string json)
        {
            var obj = JsonSerializer.Deserialize<Request>(json);
            
        }
    }
}
