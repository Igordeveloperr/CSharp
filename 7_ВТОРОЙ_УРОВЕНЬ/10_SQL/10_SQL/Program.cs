using System;

namespace _10_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDb db = new MyDb();
            db.GetResponse("SELECT * FROM `electrics_board`");
        }
    }
}
