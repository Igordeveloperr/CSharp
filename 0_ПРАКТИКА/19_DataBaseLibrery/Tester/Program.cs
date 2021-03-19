using _19_DataBaseLibrery;
using System;
using System.Collections.Generic;
using System.Data;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>
            {
                { "id", "8" }
            };
            DataBase dataBase = new DataBase("localhost", "root", "", "testdb", "3306");
            DataRow[] data = dataBase.SendRequest<string>("products", RequestType.DELETE, parameters).Result;
            foreach (var a in data)
            {
                Console.WriteLine(a.ItemArray[1]);
            }
            Console.WriteLine(data.Length);
        }
    }
}
