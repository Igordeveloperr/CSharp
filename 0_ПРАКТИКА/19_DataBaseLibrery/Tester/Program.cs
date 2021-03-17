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
            Dictionary<string, string> parameters = new Dictionary<string, string>{ { "project_id", "8" }, { "role", "прогер" } };
            DataBase dataBase = new DataBase("localhost", "root", "", "projectsfinder", "3306");
            DataRow[] data = dataBase.GetData<string>("project_role", RequestType.SELECTBYTWOPARAMETR, parameters).Result;
            foreach (var a in data)
            {
                Console.WriteLine(a.ItemArray[1]);
            }
            Console.WriteLine(data.Length);
        }
    }
}
