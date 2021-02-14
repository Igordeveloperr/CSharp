using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Net;

namespace _12_Slehka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // получаем порт из конфига
            var port = int.Parse(ConfigurationManager.AppSettings.Get("port"));
            // будем юзать UDP, конструктор хавает порт
            UdpClient client = new UdpClient(55555);

            while (true)
            {   
                // получаем картинку
                var data = await client.ReceiveAsync();
                // обрабатываем полученную фотокарточку и выводим в пикчуре бокс
                using (var ms = new MemoryStream(data.Buffer))
                {
                    pictureBox1.Image = new Bitmap(ms);
                }
                // вывожу кол-во загруженных байтов
                Text = $"Байтов получено: {data.Buffer.Length * sizeof(byte)}";
                client.Send(Encoding.UTF8.GetBytes("успех"), Encoding.UTF8.GetBytes("успех").Length, new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // получаем ip моего компа
            var host = Dns.GetHostEntry(Dns.GetHostName());
            // сортируем и выводим нужный нам ip
            MessageBox.Show(string.Join("\n", host.AddressList.
                Where(i => i.AddressFamily == AddressFamily.InterNetwork)));
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }
    }
}
