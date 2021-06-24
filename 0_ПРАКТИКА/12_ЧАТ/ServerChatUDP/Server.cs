using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerChatUDP
{
    class Server
    {
        private static string Ip;
        private static int Port;
        private IPEndPoint endPoint;
        private Socket socket;

        public Server(string ip, int port)
        {
            if (string.IsNullOrWhiteSpace(ip) || port <= 0)
            {
                throw new ArgumentException("проблема в агрументах");
            }
            Ip = ip;
            Port = port;
        }

        public void ProcessingRequest()
        {
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            var endPoint = new IPEndPoint(IPAddress.Parse(Ip), Port);
            socket.Bind(endPoint);
            byte[] data = new byte[256];
            var size = socket.Receive(data);
            Console.WriteLine(Encoding.UTF8.GetString(data));
            SendData(data, socket);
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }

        private void SendData(byte [] buffer, Socket socket)
        {
            var senderEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9000);
            socket.Connect(senderEndPoint);
            socket.Send(buffer);
        }
    }
}
