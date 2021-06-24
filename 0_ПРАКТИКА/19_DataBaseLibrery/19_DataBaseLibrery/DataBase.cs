using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using _19_DataBaseLibrery.requestBuilder;
using System.Collections.Generic;
using _19_DataBaseLibrery.requestBuilder.builderParametr;
using _19_DataBaseLibrery.myExceptions;

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

        public async Task<DataRow[]> SendRequest(Parametr parametr ,RequestType type)
        {
            if (parametr == null)
                throw new RequestParametrException("не передат объект параметров!");
            string request = Builder.RequestBuilderDictionary[type].BuildRequest(parametr, type);
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
