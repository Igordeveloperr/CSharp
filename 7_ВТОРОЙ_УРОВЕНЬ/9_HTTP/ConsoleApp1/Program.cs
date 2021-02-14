using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string responseStr = "";
            HttpListener listener = new HttpListener();
            // устанавливаю адрес прослушки
            string url = "http://localhost:8080/test/";
            listener.Prefixes.Add(url);
            // начинаю прослушивание входящих подключений
            listener.Start();
            // метод GetContext блокирует текущий поток, ожидая получение запроса
            HttpListenerContext context = listener.GetContext();
            // сам запрос
            HttpListenerRequest request = context.Request;
            // получение объекта ответа
            HttpListenerResponse response = context.Response;
            // ответ
            string responseStr = "";            
            using (StreamReader reader = new StreamReader("E:/Igor/8_CSharp/7_ВТОРОЙ_УРОВЕНЬ/9_HTTP/index.html", Encoding.UTF8))
            {
                responseStr = reader.ReadToEnd();
            }
            byte[] data = Encoding.UTF8.GetBytes(responseStr);
            // получаем поток ответа и пишем в него ответ
            response.ContentLength64 = data.Length;
            Stream output = response.OutputStream;
            // делем запись в поток
            output.Write(data, 0, data.Length);
            // закрываю поток
            output.Close();
            // закрываю прослушку
            listener.Stop();
        }
    }
}
