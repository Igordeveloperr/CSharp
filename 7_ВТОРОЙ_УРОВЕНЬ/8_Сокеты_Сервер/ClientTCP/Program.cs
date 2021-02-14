using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ClientTCP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TCP
            const string IP = "127.0.0.1"; // localhost
            const int PORT = 8080; // default port

            // формирую место подключения к нашему серваку(таких точек может быть несколько)
            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(IP), PORT);

            // создание сокета; сокет - это канал соединения для взаимодействия с сервером
            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            while (true)
            {
                Console.Write("Введите сообщение: ");
                var message = Console.ReadLine();
                // кодирую сообщение
                var data = Encoding.UTF8.GetBytes(message);
                // подключение к сокетуrf
                tcpSocket.Connect(tcpEndPoint);
                // отправка сообщения
                tcpSocket.Send(data);
                // ожидание ответа
                var buffer = new byte[256];
                var size = 0;
                var dataAnswer = new StringBuilder();
                do
                {
                    size = tcpSocket.Receive(buffer);
                    dataAnswer.Append(Encoding.UTF8.GetString(buffer, 0, size));
                }
                while (tcpSocket.Available > 0);

                Console.WriteLine(dataAnswer.ToString());
                // закрытие соединения
                tcpSocket.Shutdown(SocketShutdown.Both);
                tcpSocket.Close();

                Console.ReadLine();
            }
            #endregion
        }
    }
}
