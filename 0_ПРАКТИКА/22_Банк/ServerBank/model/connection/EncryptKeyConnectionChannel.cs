using _22_Банк.model.request;
using _22_Банк.model.request.connection;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerBank.model.connection
{
    public class EncryptKeyConnectionChannel : IConnectionChannel
    {
        private NetworkStream Stream;
        private ConnectionChannel Channel;
        public EncryptKeyConnectionChannel()
        {
            Channel = new ConnectionChannel();
        }
        public void CloseConnection(TcpClient client)
        {
            Stream.Close();
            client.Close();
        }

        public Task<TcpClient> ConnectToChannel(string ip, int port)
        {
            return Channel.ConnectToChannel(ip, port);
        }

        public void SendDataToChannel(byte[] data, TcpClient client)
        {
            Channel.SendDataToChannel(data, client);
        }
    }
}
