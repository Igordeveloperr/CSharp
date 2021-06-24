using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_ЧАТ
{
    class Client
    {
        private static string Ip;
        private static int Port;
        private IPEndPoint endPoint;
        private Socket socket;

        public Client(string ip, int port)
        {
            if (string.IsNullOrWhiteSpace(ip) || port <= 0)
            {
                throw new ArgumentException("проблема в агрументах");
            }
            Ip = ip;
            Port = port;
            endPoint = new IPEndPoint(IPAddress.Parse(Ip), port);
        }

        public void SendMessage(string message)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentException("проблема с данными!");
            }
            socket.Connect(endPoint);
            var data = Encoding.UTF8.GetBytes(message);
            socket.Send(data);
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }

        public async void PullData(ListBox outputElement)
        {
            await Task.Run(() => 
            {
                    while (true)
                    {
                        var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                        socket.Bind(endPoint);
                        byte[] data = new byte[256];
                        var size = socket.Receive(data);
                        outputElement.Items.Add($"Андрей Фомин: {Encoding.UTF8.GetString(data, 0, size)}");
                        socket.Shutdown(SocketShutdown.Both);
                        socket.Close();
                    }
            });
        }
    }
}
