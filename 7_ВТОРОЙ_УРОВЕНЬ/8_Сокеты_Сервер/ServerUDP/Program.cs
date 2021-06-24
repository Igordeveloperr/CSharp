using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerUDP
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ip = "127.0.0.1";
            const int port = 8081;

            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.Bind(iPEndPoint);

            // кому отправляем
            EndPoint sendlerEndPoint = new IPEndPoint(IPAddress.Any, 0);
            while (true)
            {
                var buffer = new byte[1000];
                var size = 0;
                var data = new StringBuilder();
                do
                {
                    size = socket.ReceiveFrom(buffer, ref sendlerEndPoint);
                    data.Append(Encoding.UTF8.GetString(buffer, 0, size));
                }
                while (socket.Available > 0);
                Console.WriteLine(data);
                // отправляю сообщение
                socket.SendTo(Encoding.UTF8.GetBytes("Успех"), sendlerEndPoint);

                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
        }
    }
}
