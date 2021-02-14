using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace _10_SQL
{
    internal class MyDb
    {
        private MySqlConnection Connection;
        private MySqlCommand Command;
        private Dictionary<string, string> Settings = new Dictionary<string, string>
        {
            {"server", "localhost"},
            {"user", "root"},
            {"db", "sharpdb"},
            {"port", "3306"},
            {"password", ""},
        };
        private string ConnectString;
        internal MyDb()
        {
            ConnectString = $"server={Settings["server"]};user={Settings["user"]};database={Settings["db"]};port={Settings["port"]};password={Settings["password"]};";
            Connection = new MySqlConnection(ConnectString);
        }
        internal async void GetResponse(string req)
        {
            var data = await SendRequest(req);
            string output = "";
            foreach (var item in data)
            {
                for(int i = 0; i < item.ItemArray.Length; i++)
                {
                    output += $"{item.ItemArray[i]} -";
                }
            }
            Console.WriteLine(output);
        }
        private async Task<DataRow[]> SendRequest(string req)
        {
            Command = new MySqlCommand(req, Connection);
            await Connection.OpenAsync();
            await Command.ExecuteNonQueryAsync();
            MySqlDataAdapter adapter = new MySqlDataAdapter(Command);
            DataTable dataTable = new DataTable();
            await adapter.FillAsync(dataTable);
            DataRow[] data = dataTable.Select();
            return data;
        }
    }
}
