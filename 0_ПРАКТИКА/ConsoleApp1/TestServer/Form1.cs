using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestServer
{
    public partial class Form1 : Form
    {
        const string ip = "127.0.0.1";
        const int port = 8000;
        private static IPEndPoint clientEndPoint;
        private static Socket client;
        public Form1()
        {
            InitializeComponent();
            clientEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            client.Bind(clientEndPoint);
            client.Listen(5);
            await ParseData();
        }

        private async Task ParseData()
        {
            await Task.Run(() => 
            {   
                while (true)
                {
                    var listener = client.Accept();
                    byte[] buffer = new byte[100000];
                    var size = listener.Receive(buffer);
                    var data = new StringBuilder();

                    data.Append(Encoding.UTF8.GetString(buffer, 0, size));
                    textBox1.Text = data.ToString();

                    listener.Shutdown(SocketShutdown.Both);
                    listener.Close();
                }
            }
            );
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
