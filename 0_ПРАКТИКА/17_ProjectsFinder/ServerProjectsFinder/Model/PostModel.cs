using _17_ProjectsFinder.Send.Settings;
using Newtonsoft.Json;
using ServerProjectsFinder.db;
using ServerProjectsFinder.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerProjectsFinder.Model
{
    internal class PostModel
    {
        private NetworkStream Stream;
        private RequestSetting Setting = new RequestSetting();
        public DataRow[] LoadAllPost()
        {
            var array = DataBase.DataBaseObj.GetData("SELECT * FROM project ORDER BY id DESC").Result;
            return array;
        }

        public void SendAllPostToClient(DataRow[] data)
        {
            List<PostView> list = new List<PostView>();
            foreach (var post in data)
            {
                PostView sendPost = new PostView(
                    (int)post["id"],
                    (string)post["title"],
                    (string)post["text"],
                    (string)post["type"]
                );
                list.Add(sendPost);
            }
            SendViewToClient(list);
        }
        private async void SendViewToClient(List<PostView> obj)
        {
            TcpClient client = new TcpClient();
            string sendJson = JsonConvert.SerializeObject(obj);
            byte[] sendData = Encoding.UTF8.GetBytes(sendJson);
            if (!client.Connected)
            {
                await client.ConnectAsync(Setting.Ip, 7000);
            }
            Stream = client.GetStream();
            Stream.Write(sendData);
        } 
    }
}
