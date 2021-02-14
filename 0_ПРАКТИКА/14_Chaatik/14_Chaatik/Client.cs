using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_Chaatik
{
    class Client
    {
        private const string IP = "127.0.0.1";
        private const int PORT = 8090;
        TcpClient client;
        UdpClient udpClient;

        public async void SendMessage(string message)
        {
            client = new TcpClient();
            await Task.Run(() => {
                TryConnect();
                NetworkStream stream = client.GetStream();
                if (string.IsNullOrWhiteSpace(message))
                {
                    MessageBox.Show("пустая строка!!!");
                    throw new ArgumentException("пустая строка");
                }
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
                stream.Close();
                client.Close();
            });
        }
        public async void ReciveMessage(ListBox list)
        {   
            while (true)
            {
                    udpClient = new UdpClient(8090);
                    string message = "";
                    await Task.Run(() =>
                    {
                        IPEndPoint ip = null;
                        byte[] data = udpClient.Receive(ref ip);
                        message = Encoding.UTF8.GetString(data);
                        list.Items.Add(message);
                        udpClient.Close();
                    });
            }
        }
        private void TryConnect()
        {
            do
            {
                try
                {
                    client.Connect(IP, PORT);
                    if (!client.Connected)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("бон боон...");
                }
            } while (!client.Connected);
        }
    }
}
