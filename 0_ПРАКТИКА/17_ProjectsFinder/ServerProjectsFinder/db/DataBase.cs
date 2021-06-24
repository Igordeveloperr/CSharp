using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ServerProjectsFinder.db
{
    public class DataBase
    {
        private DataBaseSetting DataBaseSettingObj = new DataBaseSetting();
        private MySqlConnection Connection;
        private MySqlCommand Command;
        internal string ConnectString { get; private set; }
        private static readonly DataBase dataBaseObj = new DataBase();
        public static DataBase DataBaseObj { get { return dataBaseObj; } }
        private DataBase()
        {
            ConnectString = $"server={DataBaseSettingObj.Server};user={DataBaseSettingObj.User};database={DataBaseSettingObj.Db};port={DataBaseSettingObj.Port};password={DataBaseSettingObj.Password};charset=utf8";
        }
        public async Task<DataRow[]> GetData(string req)
        {
            DataRow[] data = null;
            try
            {
                Connection = new MySqlConnection(ConnectString);
                Command = new MySqlCommand(req, Connection);
                await Connection.OpenAsync();
                await Command.ExecuteNonQueryAsync();
                MySqlDataAdapter adapter = new MySqlDataAdapter(Command);
                DataTable dataTable = new DataTable();
                await adapter.FillAsync(dataTable);
                data = dataTable.Select();
                Connection.Close();
            }
            catch(MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return data;
        }
        public async void InsertData(string login, string role, int id)
        {
            try
            {
                Connection = new MySqlConnection(ConnectString);
                await Connection.OpenAsync();
                Command = Connection.CreateCommand();
                Command.CommandText = "INSERT INTO `project_role`(`id`, `login`, `role`, `project_id`) VALUES (null, ?login, ?role, ?id)";
                Command.Parameters.AddWithValue("?login", login.ToLower());
                Command.Parameters.AddWithValue("?role", role);
                Command.Parameters.AddWithValue("?id", id);
                await Command.ExecuteNonQueryAsync();
                Connection.Close();
            }
            catch(MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
