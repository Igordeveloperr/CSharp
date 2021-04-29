using ServerBank.exception;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerBank.routing
{
    internal class Router : IRouter
    {
        private NetworkStream Stream;
        private TcpListener Listener;
        public Router()
        {
            Listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 80);
            try 
            {
                Listener.Start();
            }
            catch (StartTcpListenerException e) { Console.WriteLine(e.Message); }
        }
        public async Task<TcpClient> ConnectClientToChannel()
        {
            TcpClient client = await Listener.AcceptTcpClientAsync();
            try
            {
                if (!client.Connected) throw new ClientConnectException("пользователь не смог подключиться");
            }
            catch (ClientConnectException e)
            {
                Console.WriteLine(e.Message);
            }
            return client;
        }
        public string GetDataFromConnectionChannel(TcpClient client)
        {
            Stream = client.GetStream();
            if (!Stream.CanRead) throw new StreamException("не удается прочитать поток");
            byte[] data = new byte[804];
            string json = string.Empty;
            do
            {
                int count = Stream.Read(data, 0, data.Length);
                json = Encoding.UTF8.GetString(data, 0, count);
            }
            while (Stream.DataAvailable);
            return json;
        }
        public void CloseConnectionChannel(TcpClient client)
        {
            Stream.Close();
            client.Close();
        }
    }
}
