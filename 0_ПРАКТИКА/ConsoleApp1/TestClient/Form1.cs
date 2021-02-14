using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestClient
{
    public partial class Form1 : Form
    {
        const string ip = "127.0.0.1";
        const int port = 8000;
        private static IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
        private static Socket client;
        public Form1()
        {
            InitializeComponent();
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            string filePath = "";
            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.ShowDialog();
                filePath = fileDialog.FileName;
                MessageBox.Show(filePath);

                var file = fileDialog.OpenFile();

                await SendFileToServer(file);
                button1.Enabled = true;
            }
        }

        private async Task SendFileToServer(Stream file)
        {       
            //IPEndPoint serverEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            //TcpClient client = new TcpClient(serverEndPoint);
            await Task.Run(() =>
            {
                string output = "";
                using (var rd = new StreamReader(file))
                {
                    output += rd.ReadLine();
                    MessageBox.Show(output);
                }

                var data = Encoding.UTF8.GetBytes(output);
                client.Connect(serverEndPoint);
                client.Send(data);
                client.Shutdown(SocketShutdown.Both);
                client.Close();
            }
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
