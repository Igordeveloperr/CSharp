using _22_Банк.exception;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _22_Банк.model.request
{
    internal class ConnectionChannel
    {
        private NetworkStream Stream;
        public async Task<TcpClient> ConnectToChannel()
        {
            TcpClient client = new TcpClient();
            try
            {
                await client.ConnectAsync("127.0.0.1", 80);
            }
            catch (SocketException e)
            {
                MessageBox.Show(e.Message);
            }
            return client;
        }
        public void SendDataToChannel(byte[] data, TcpClient client)
        {
            try
            {
                if (client == null) throw new ArgumentException(nameof(client));
                if (!client.Connected) throw new ClientConnectException("вы не подключились к серверу");
                if (data == null) throw new ArgumentException(nameof(data));
                Stream = client.GetStream();
                if (!Stream.CanWrite) throw new StreamException("не удается отправить данные");
                Stream.Write(data, 0, data.Length);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
