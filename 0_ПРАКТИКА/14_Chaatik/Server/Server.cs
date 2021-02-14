using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    class Server
    {
        private const string IP = "127.0.0.1";
        private const int PORT = 8090;
        private TcpListener listener = new TcpListener(IPAddress.Parse(IP), PORT);
        public Server()
        {
            listener.Start();
        }
        public async void ObserveChat(Button indicator)
        {
            await Task.Run(()=> {
                TcpClient client = listener.AcceptTcpClient();
                NetworkStream stream = client.GetStream();
                byte[] data = new byte[1024];
                StringBuilder builder = new StringBuilder();
                if (stream.CanRead)
                {
                    indicator.BackColor = Color.Green;
                    do
                    {
                        int length = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.UTF8.GetString(data, 0, length));
                        SendMessageToChat(builder.ToString());
                    } while (stream.DataAvailable);
                    indicator.BackColor = Color.Red;
                    stream.Close();
                    client.Close();
                }
                else
                {
                    throw new ApplicationException("нет данных в потоке");
                }
            });
        }

        private void SendMessageToChat(string message)
        {
            try
            {
                UdpClient udpClient = new UdpClient();
                byte[] data = Encoding.UTF8.GetBytes(message);
                udpClient.Send(data, data.Length, "127.0.0.1", 8090);
                udpClient.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
