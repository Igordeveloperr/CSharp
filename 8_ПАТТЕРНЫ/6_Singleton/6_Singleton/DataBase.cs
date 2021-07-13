using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Singleton
{
    class DataBase
    {
        private static DataBase _db;
        protected DataBase()
        {
        }
        public static DataBase Instance()
        {
            if (_db == null)
                _db = new DataBase();
            return _db;
        }
        public void Select()
        {
            Console.WriteLine("select data");
        }
        public void Delete()
        {
            Console.WriteLine("delete data");
        }
    }
}
