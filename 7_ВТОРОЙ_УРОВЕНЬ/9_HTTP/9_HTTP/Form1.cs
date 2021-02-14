using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_HTTP
{
    public partial class Form1 : Form
    {   
        private string responseStr = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listen();
        }

        private async Task Listen()
        {

                HttpListener listener = new HttpListener();
                // устанавливаю адрес прослушки
                string url = "http://localhost:8080/test/";
                listener.Prefixes.Add(url);
                // начинаю прослушивание входящих подключений
                listener.Start();
                // метод GetContext блокирует текущий поток, ожидая получение запроса
                HttpListenerContext context = await listener.GetContextAsync();
                // сам запрос
                HttpListenerRequest request = context.Request;
                // получение объекта ответа
                HttpListenerResponse response = context.Response;
                // ответ
                //await ParseHtmlAsync();
                // шифрую строку
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

        private async Task ParseHtmlAsync()
        {
            await Task.Run(() =>
            {
                using (StreamReader reader = new StreamReader("E:/Igor/8_CSharp/7_ВТОРОЙ_УРОВЕНЬ/9_HTTP/index.html", Encoding.UTF8))
                {
                    while (!reader.EndOfStream)
                    {
                        responseStr += reader.ReadLine();
                    }
                }
            });
        }
    }
}
