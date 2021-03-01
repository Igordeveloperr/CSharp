using ServerProjectsFinder.conf;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using _17_ProjectsFinder.Send;
using Newtonsoft.Json;
using _17_ProjectsFinder.Send.Settings;
using ServerProjectsFinder.Controller;
using ServerProjectsFinder.Controllers;

namespace ServerProjectsFinder
{
    class Router : IRouter
    {
        private Dictionary<string, ControllerBase> Controllers = new Dictionary<string, ControllerBase>
        {
            {"authorization", new AuthorizationController() },
            {"posts", new PostController() },
            {"insert_user", new InsertUserController() },
        };
        private TcpListener listener;
        public byte[] Data { get; } = new byte[1024];
        internal NetworkStream Stream;
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
                    Console.WriteLine(json);
                }
                while (Stream.DataAvailable);
                var obj = JsonConvert.DeserializeObject<Request>(json);
                SelectController(json, obj.Type);
            }
            Stream.Close();
            client.Close();
        }

        private void SelectController(string json, string reqType)
        {
            Controllers[reqType].Work(json);
        }
    }
}
