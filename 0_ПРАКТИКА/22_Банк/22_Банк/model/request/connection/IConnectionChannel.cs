using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace _22_Банк.model.request.connection
{
    public interface IConnectionChannel
    {
        public Task<TcpClient> ConnectToChannel(string ip, int port);
        public void SendDataToChannel(byte[] data, TcpClient client);
        public void CloseConnection(TcpClient client);
    }
}
