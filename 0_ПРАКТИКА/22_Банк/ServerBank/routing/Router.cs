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
        public async void ListenConnectionChannel()
        {
            try
            {
                TcpClient client = await Listener.AcceptTcpClientAsync();
                if (!client.Connected) throw new ClientConnectException("пользовательно не смог подключиться");
                Stream = client.GetStream();
                if (!Stream.CanRead) throw new StreamException("не удается прочитать поток");
                string json = GetDataFromConnectionChannel(Stream);
                Console.WriteLine(json);
                Stream.Close();
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private string GetDataFromConnectionChannel(NetworkStream stream)
        {
            StringBuilder builder = new StringBuilder();
            byte[] data = new byte[1024];
            string json = string.Empty;
            do
            {
                int count = stream.Read(data, 0, data.Length);
                json = builder.Append(Encoding.UTF8.GetString(data, 0, count)).ToString();
            }
            while (stream.DataAvailable);
            return json;
        }
    }
}
