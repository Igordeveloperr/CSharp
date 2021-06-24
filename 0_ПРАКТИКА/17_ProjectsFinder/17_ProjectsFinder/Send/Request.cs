
using _17_ProjectsFinder.Send.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Windows;

namespace _17_ProjectsFinder.Send
{
    public class Request
    {
        private NetworkStream Stream;
        public string Type { get; protected set; }
        public RequestSetting Setting { get; protected set; } = new RequestSetting(); 
        [JsonConstructor]
        public Request(string type)
        {
            if (!string.IsNullOrWhiteSpace(type))
            {
                Type = type;
            }
        }
        public async void SendRequest()
        {
            string jsonData = JsonConvert.SerializeObject(this);
            TcpClient Client = new TcpClient();
            byte[] data = Encoding.UTF8.GetBytes(jsonData);
            await Client.ConnectAsync(Setting.Ip, Setting.Port);
            Stream = Client.GetStream();
            Stream.Write(data, 0, data.Length);
            Stream.Close();
            Client.Close();
        }
    }
}
