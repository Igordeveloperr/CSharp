using _17_ProjectsFinder.Send.response.copyView;
using _17_ProjectsFinder.Send.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _17_ProjectsFinder.Send.response
{
    internal class PostResponse
    {
        private NetworkStream Stream;
        private RequestSetting Setting = new RequestSetting();
        internal async Task<List<PostView>> GetPostResponse()
        {
            List<PostView> postList = new List<PostView>();
            var listener = new TcpListener(IPAddress.Parse(Setting.Ip), 7000);
            listener.Start();
            TcpClient client = listener.AcceptTcpClient();
            byte[] data = new byte[1024];
            string res = "";
            Stream = client.GetStream();
            do
            {
                int count = await Stream.ReadAsync(data, 0, data.Length);
                res = Encoding.UTF8.GetString(data, 0, count);
                postList = JsonConvert.DeserializeObject<List<PostView>>(res);
            } while (Stream.DataAvailable);
            Stream.Close();
            client.Close();
            return postList;
        }
    }
}
