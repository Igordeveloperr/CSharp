using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace _4_паттерн_MVVM.model.db
{
    internal class DataBase : IDataBaseSetting
    {
        private MySqlConnection Connection;
        private MySqlCommand Command; 
        private string ConnectionString { get; }

        public string Host { get; } = "localhost";

        public string User { get; } = "root";

        public string Db { get; } = "projectsfinder";

        public string Port { get; } = "3306";

        public string Possword { get; } = "";

        public DataBase()
        {
            ConnectionString = $"server={Host};user={User};database={Db};port={Port};password={Possword};charset=utf8";
        }
        public async Task<List<T2>> SendRequestWithParametr<T, T2>(T paramert, string column)
        {
            List<T2> list = new List<T2>();
            if(paramert != null && column != null)
            {
                try
                {
                    Connection = new MySqlConnection(ConnectionString);
                    await Connection.OpenAsync();
                    Command = Connection.CreateCommand();
                    Command.CommandText = "";
                }
                catch (MySqlException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return list;
        }
    }
}
