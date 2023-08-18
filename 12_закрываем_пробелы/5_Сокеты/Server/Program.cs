using System.Net;
using System.Net.Sockets;
using System.Text;

const string IP = "127.0.0.1";
const int PORT = 1488;
const byte MAX_QUEUE_LEN = 5;

// основная точка входа
var endpoint = new IPEndPoint(IPAddress.Parse(IP), PORT);
var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

// связываю сокет с конечной точкой и получаю точку подключения
socket.Bind(endpoint);

// включаем прослушивание
socket.Listen(MAX_QUEUE_LEN);
var data = new StringBuilder();

while(true)
{
    // подключение конкретного клиента
    var listener = socket.Accept();
    // буфер для данных
    var buffer = new byte[256];
    var size = 0;

    // получаем данные
    do
    {
        size = listener.Receive(buffer);

        // декодирую полученные байты
        data.Append(Encoding.UTF8.GetString(buffer, 0, size));
    } 
    while (listener.Available > 0);

    Console.WriteLine($"Buffer: {buffer}");
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine($"Data: {data}");

    // отправляю ответ клиенту
    listener.Send(Encoding.UTF8.GetBytes("Accept data!"));

    // закрываем соединение
    listener.Shutdown(SocketShutdown.Both);
    listener.Close();
}