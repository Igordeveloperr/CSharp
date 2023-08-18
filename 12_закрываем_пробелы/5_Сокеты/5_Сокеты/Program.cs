using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

const string IP = "127.0.0.1";
const int PORT = 1488;
const byte MAX_QUEUE_LEN = 5;

// основная точка входа
var endpoint = new IPEndPoint(IPAddress.Parse(IP), PORT);
var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

Console.Write("Enter data: ");
var message = string.Empty ?? Console.ReadLine();
var data = Encoding.UTF8.GetBytes(message);
var builder = new StringBuilder();


// подключаемся к серверу
socket.Connect(endpoint);
// отправляем данные
socket.Send(data);

// получает ответ
// буфер для данных
var buffer = new byte[256];
var size = 0;

// получаем данные
do
{
    size = socket.Receive(buffer);

    // декодирую полученные байты
    builder.Append(Encoding.UTF8.GetString(buffer, 0, size));
}
while (socket.Available > 0);

Console.WriteLine(builder.ToString());
// закрываю соединение
socket.Shutdown(SocketShutdown.Both);
socket.Close();