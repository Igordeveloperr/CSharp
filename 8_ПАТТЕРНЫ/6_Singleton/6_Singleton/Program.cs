using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase db1 = DataBase.Instance();
            DataBase db2 = DataBase.Instance();
            Console.WriteLine(ReferenceEquals(db1, db2));
            db1.Select();
            db2.Delete();

            Console.ReadKey();
        }
    }
}
