using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerBank.routing
{
    internal interface IRouter
    {
        public Task<TcpClient> ConnectClientToChannel();
    }
}
