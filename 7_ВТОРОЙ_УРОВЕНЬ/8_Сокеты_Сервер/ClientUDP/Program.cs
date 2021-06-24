using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ClientUDP
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ip = "127.0.0.1";
            const int port = 8082;

            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.Bind(iPEndPoint);
            // отправка сообщения
            while (true)
            {
                Console.WriteLine("Сообщение: ");
                var message = Console.ReadLine();
                var serverEndPoint = new IPEndPoint(IPAddress.Parse(ip), 8081);
                socket.SendTo(Encoding.UTF8.GetBytes(message), serverEndPoint);

                var buffer = new byte[1000];
                var size = 0;
                var data = new StringBuilder();
                EndPoint senderEndPoint = new IPEndPoint(IPAddress.Any, 0);
                do
                {
                    size = socket.ReceiveFrom(buffer, ref senderEndPoint);
                    data.Append(Encoding.UTF8.GetString(buffer, 0, size));
                }
                while (socket.Available > 0);
                Console.WriteLine(data);

                Console.ReadLine();
            }
        }
    }
}
