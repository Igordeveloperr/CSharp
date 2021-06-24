using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private static string serverIP = "192.168.0.100";
        private static int serverPort = 55555;
        private static IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(serverIP), serverPort);
        private static UdpClient client = new UdpClient(serverPort);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // сформировал адрес сервера, на который буду отправлять видево
      
            // получение видеводивайсов
            var videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            // находим камеру, она под 0 индексом по умолчанию
            var videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            // подписываюсь на событие
            videoSource.NewFrame += VideoSource_NewFrame;
            // начинаем тырить видево с вебки
            videoSource.Start();
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //  картинку в  800x600
            var bmp = new Bitmap(eventArgs.Frame, 800, 600);

            // отправка
            try
            {
                using (var ms = new MemoryStream())
                {
                    // сохраняем нашу картинку в объект ms
                    bmp.Save(ms, ImageFormat.Jpeg);
                    // конвертируем ее в байты
                    var bytes = ms.ToArray();
                    // сама отправка
                    client.Send(bytes, bytes.Length, serverEndPoint);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
