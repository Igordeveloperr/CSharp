using _17_ProjectsFinder.Send.Settings;
using MySql.Data.MySqlClient;
using ServerProjectsFinder.db;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ServerProjectsFinder.Model
{
    internal class InsertUserModel
    {
        private const int EmptyArray = 0;
        private RequestSetting Setting = new RequestSetting();
        public void InsertUser(string name, string role, int id)
        {
            bool checkedFlag = CheckUser(name, id).Result;
            if (checkedFlag)
            {
                DataBase.DataBaseObj.InsertData(name, role, id);
                SendResultOfConnect("Вы присоединились!");
            }
            else
            {
                Console.WriteLine("уже есть в этом проекте");
                SendResultOfConnect("Вы уже являйтесь участником проекта!");
            }
        }

        private async Task<bool> CheckUser(string login, int id)
        {
            bool result = true;
            try
            {
                var Connection = new MySqlConnection(DataBase.DataBaseObj.ConnectString);
                await Connection.OpenAsync();
                var Command = Connection.CreateCommand();
                Command.CommandText = "SELECT * FROM project_role WHERE login=?login AND project_id=?id";
                Command.Parameters.AddWithValue("?login", login);
                Command.Parameters.AddWithValue("?id", id);
                await Command.ExecuteNonQueryAsync();
                MySqlDataAdapter adapter = new MySqlDataAdapter(Command);
                DataTable dataTable = new DataTable();
                await adapter.FillAsync(dataTable);
                DataRow[] data = dataTable.Select();
                if (data.Length > EmptyArray) result = false;
                Connection.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }

        private async void SendResultOfConnect(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            try
            {
                TcpClient client = new TcpClient();
                await client.ConnectAsync(IPAddress.Parse(Setting.Ip), 4343);
                NetworkStream stream = client.GetStream();
                stream.Write(data);
                stream.Close();
                client.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
