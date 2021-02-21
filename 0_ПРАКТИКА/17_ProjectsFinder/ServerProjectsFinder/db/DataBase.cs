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
        private string ConnectString;
        private static readonly DataBase dataBaseObj = new DataBase();
        public static DataBase DataBaseObj { get { return dataBaseObj; } }
        private DataBase()
        {
            ConnectString = $"server={DataBaseSettingObj.Server};user={DataBaseSettingObj.User};database={DataBaseSettingObj.Db};port={DataBaseSettingObj.Port};password={DataBaseSettingObj.Password};";
        }
        public async Task<DataRow[]> GetData(string req)
        {   
            Connection = new MySqlConnection(ConnectString);
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
