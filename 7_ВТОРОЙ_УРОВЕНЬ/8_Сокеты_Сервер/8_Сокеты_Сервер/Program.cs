using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _8_Сокеты_Сервер
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TCP server
            const string IP = "127.0.0.1"; // localhost
            const int PORT = 8080; // default port

            // формирую место подключения к нашему серваку(таких точек может быть несколько)
            var tcpEndPoint = new IPEndPoint(IPAddress.Parse(IP), PORT);
            // создание сокета; сокет - это канал соединения для взаимодействия с сервером
            var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // перевод сокета в режим ожидания, чтобы он ждал запроса на сервер
            tcpSocket.Bind(tcpEndPoint); // ждем запрос по такому-то адресу и порту
            // запуск сокета, для начала прослушки
            tcpSocket.Listen(3); // параметр отвечает за максимальное кол-во клиентов, которые могут обращатся к сокету по этому порту

            // реализуем сам процесс прослушивания
            while (true)
            {
                // обработчик запросов конкретного клиента
                var listener = tcpSocket.Accept();
                // буфер - место, куда мы принимаем данные
                var buffer = new byte[256]; // сообщение длиной максимум 256 байт
                // кол-во полученых данных
                var size = 0;
                // собиратель полученных данных
                var data = new StringBuilder();
                do
                {   
                    // записываю длину сообщения
                    size = listener.Receive(buffer);
                    // раскодирование полученных байт в строку и сбор из них сообщения
                    data.Append(Encoding.UTF8.GetString(buffer, 0, size));
                } 
                while (listener.Available > 0); // если мы получили запрос, длина сообщения > 0
                // вывод полученных данных
                Console.WriteLine(data);
                // обратный ответ(кодирование текстового сообщения в байты)
                listener.Send(Encoding.UTF8.GetBytes("запрос успешно обработан!"));
                // закрытие подключения у клиента и сервера
                listener.Shutdown(SocketShutdown.Both);
                listener.Close();
            }
            #endregion

        }
    }
}
