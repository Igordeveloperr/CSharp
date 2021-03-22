using _19_DataBaseLibrery;
using _19_DataBaseLibrery.requestBuilder.builderParametr;
using System;
using System.Data;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase dataBase = new DataBase("localhost", "root", "", "testdb", "3306");
            DataRow[] data = dataBase.SendRequest(new SelectParametr("products"), RequestType.SELECTALL).Result;
            foreach (var a in data)
            {
                Console.WriteLine(a.ItemArray[1]);
            }
        }
    }
}
