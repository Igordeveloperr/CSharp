using _17_ProjectsFinder.Send.response.copyView;
using _17_ProjectsFinder.Send.Settings;
using Newtonsoft.Json;
using ServerProjectsFinder.myException;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _17_ProjectsFinder.Send.response
{
    internal class UpdateUserListResponse
    {
        private RequestSetting Settings = new RequestSetting();
        private NetworkStream Stream;
        public async Task<List<UpdateUserListView>> GetUserList()
        {
            List<UpdateUserListView> list = new List<UpdateUserListView>();
            byte[] data = new byte[256];
            TcpListener listener = new TcpListener(IPAddress.Parse(Settings.Ip), 2121);
            TcpClient client = new TcpClient();
            try
            {
                listener.Start();
                client = await listener.AcceptTcpClientAsync();
                if (!client.Connected) throw new ConnectException("не удалось подключить клиента!");
                Stream = client.GetStream();
                if (!Stream.CanRead) throw new StreamException("ошибка получения данных!");
                do
                {
                    int count = await Stream.ReadAsync(data, 0, data.Length);
                    string json = Encoding.UTF8.GetString(data, 0, count);
                    list = JsonConvert.DeserializeObject<List<UpdateUserListView>>(json);
                } while (Stream.DataAvailable);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            Stream.Close();
            client.Close();
            listener.Stop();
            return list;
        }
    }
}
