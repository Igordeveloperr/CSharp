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
        private byte[] DataJson;
        public RequestSendler(byte[] dataJson)
        {
            Channel = new ConnectionChannel();
            if (dataJson == null)
                throw new ArgumentException(nameof(dataJson));
            DataJson = dataJson;
        }
        public async void SendRequest()
        {
            TcpClient client = await Task.Run(()=> Channel.ConnectToChannel("127.0.0.1",80).Result);
            Channel.SendDataToChannel(DataJson, client);
            Channel.CloseConnection(client);
        }
    }
}
