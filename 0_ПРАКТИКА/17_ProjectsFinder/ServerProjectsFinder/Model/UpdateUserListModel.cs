using _17_ProjectsFinder.Send.Settings;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using ServerProjectsFinder.db;
using ServerProjectsFinder.myException;
using ServerProjectsFinder.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerProjectsFinder.Model
{
    internal class UpdateUserListModel
    {
        private RequestSetting Setting = new RequestSetting();
        private NetworkStream Stream;
        public async void SendUserToClient(List<UpdateUserListView> list)
        {
            TcpClient client = new TcpClient();
            string json = JsonConvert.SerializeObject(list);
            byte[] data = Encoding.UTF8.GetBytes(json);
            try
            {
                await client.ConnectAsync(IPAddress.Parse(Setting.Ip), 2121);
                if (!client.Connected) throw new ConnectException("не удалось подлючиться к клиенту!");
                Stream = client.GetStream();
                if (!Stream.CanWrite) throw new StreamException("поток недоступен для записи!");
                Stream.Write(data);
                Stream.Close();
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public async Task<List<UpdateUserListView>> LoadUserListByPostId(int postId)
        {
            List<UpdateUserListView> list = new List<UpdateUserListView>();
            try
            {
                var Connection = new MySqlConnection(DataBase.DataBaseObj.ConnectString);
                await Connection.OpenAsync();
                var Command = Connection.CreateCommand();
                Command.CommandText = "SELECT * FROM project_role WHERE project_id=?postId";
                Command.Parameters.AddWithValue("?postId", postId);
                using(DbDataReader reader = Command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int index = reader.GetOrdinal("login");
                            string user = reader.GetString(index);
                            list.Add(new UpdateUserListView(user));
                        }
                    }
                }
                Command.ExecuteNonQuery();
                Connection.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return list;
        }
    }
}
