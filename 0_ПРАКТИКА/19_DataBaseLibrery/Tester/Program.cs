using _19_DataBaseLibrery;
using System;
using System.Data;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase dataBase = new DataBase("localhost", "root", "", "projectsfinder", "3306");
            DataRow[] data = dataBase.SelectAndSortByParametr<int>("project_role", "project_id", 9).Result;
            
        }
    }
}
