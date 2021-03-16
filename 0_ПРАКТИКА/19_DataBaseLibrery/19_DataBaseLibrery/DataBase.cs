using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;

namespace _19_DataBaseLibrery
{
    public class DataBase
    {
        private MySqlConnection Connection;
        private MySqlCommand Command;
        private string ConnectionString;
        public DataBase(string host, string user, string password, string db, string port)
        {
            ConnectionString = $"server={host};user={user};database={db};port={port};password={password};charset=utf8";
        }
        public async Task<DataRow[]> SelectAllFromTable(string table)
        {
            if (string.IsNullOrWhiteSpace(table)) throw new ArgumentException(nameof(table));
            DataRow[] data = null;
            try
            {
                Connection = new MySqlConnection(ConnectionString);
                await Connection.OpenAsync();
                Command = Connection.CreateCommand();
                Command.CommandText = $"SELECT * FROM {table} ORDER BY id DESC";
                MySqlDataAdapter adapter = new MySqlDataAdapter(Command);
                DataTable dataTable = new DataTable();
                await adapter.FillAsync(dataTable);
                data = dataTable.Select();
                Connection.Close();
            }
            catch (MySqlException e)
            {
                throw new Exception(Convert.ToString(e.Number));
            }
            return data;
        }

        public async Task<DataRow[]> SelectAndSortByParametr<T>(string table, string parametr, T parametrValue)
        {
            if (string.IsNullOrWhiteSpace(table)) throw new ArgumentException(nameof(table));
            if (string.IsNullOrWhiteSpace(parametr)) throw new ArgumentException(nameof(parametr));
            if (parametrValue == null) throw new ArgumentException(nameof(parametrValue));
            DataRow[] data = null;
            try
            {
                Connection = new MySqlConnection(ConnectionString);
                await Connection.OpenAsync();
                Command = Connection.CreateCommand();
                Command.CommandText = $"SELECT * FROM {table} WHERE {parametr} = '{parametrValue}'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(Command);
                DataTable dataTable = new DataTable();
                await adapter.FillAsync(dataTable);
                data = dataTable.Select();
                Connection.Close();
            }
            catch (MySqlException e)
            {
                throw new Exception(Convert.ToString(e.Message));
            }
            return data;
        }
    }
}
