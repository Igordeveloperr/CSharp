using _22_Банк.exception;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using _22_Банк.model.request.connection;

namespace _22_Банк.model.request
{
    public class ConnectionChannel : IConnectionChannel
    {
        private NetworkStream Stream;
        public async Task<TcpClient> ConnectToChannel(string ip, int port)
        {
            TcpClient client = new TcpClient();
            try
            {
                if (string.IsNullOrWhiteSpace(ip) || port <= 0)
                    throw new ArgumentException("шото не так тут");
                await client.ConnectAsync(ip, port);
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
        public async Task<string> GetResponse(TcpClient client)
        {
            byte[] data = new byte[1024];
            int count = await Stream.ReadAsync(data, 0, data.Length);
            string result = Encoding.UTF8.GetString(data, 0, count);
            return result;
        }
        public void CloseConnection(TcpClient client)
        {
            Stream.Close();
            client.Close();
        }
    }
}
