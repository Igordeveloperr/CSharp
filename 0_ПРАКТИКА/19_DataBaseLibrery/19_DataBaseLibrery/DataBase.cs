using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using _19_DataBaseLibrery.requestBuilder;
using System.Collections.Generic;

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
        public async Task<DataRow[]> SendRequest(string table, RequestType type)
        {
            if (string.IsNullOrWhiteSpace(table)) throw new ArgumentException(nameof(table));
            string request = Builder<bool>.RequestBuilderDictionary[type].BuildRequest(table);
            DataRow[] data = null;
            try
            {
                Connection = new MySqlConnection(ConnectionString);
                await Connection.OpenAsync();
                Command = Connection.CreateCommand();
                Command.CommandText = request;
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

        public async Task<DataRow[]> SendRequest<T>(string table, RequestType type, Dictionary<string, T> parameters)
        {
            if (string.IsNullOrWhiteSpace(table)) throw new ArgumentException(nameof(table));
            string request = Builder<T>.RequestBuilderDictionary[type].BuildRequest(table, parameters, type);
            DataRow[] data = null;
            try
            {
                Connection = new MySqlConnection(ConnectionString);
                await Connection.OpenAsync();
                Command = Connection.CreateCommand();
                Command.CommandText = request;
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
