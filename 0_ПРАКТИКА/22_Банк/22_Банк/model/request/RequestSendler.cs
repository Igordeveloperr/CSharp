using _22_Банк.encrypt;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _22_Банк.model.request
{
    internal class RequestSendler : IRequestSendler
    {
        private ConnectionChannel Channel;
        private string Json;
        public RequestSendler(string json)
        {
            Channel = new ConnectionChannel();
            if (string.IsNullOrWhiteSpace(json))
                throw new ArgumentException(nameof(json));
            Json = json;
        }
        public async void SendRequest()
        {
            byte[] data = Encoding.UTF8.GetBytes(Json);
            TcpClient client = await Task.Run(()=> Channel.ConnectToChannel().Result);
            Channel.SendDataToChannel(data, client);
        }
    }
}
