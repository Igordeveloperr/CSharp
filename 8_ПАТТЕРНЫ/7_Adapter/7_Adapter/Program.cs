using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin();
            bool isAdmin = admin.Authorization("bobiks");
            Console.WriteLine($"is Admin {isAdmin}");

            DefaultUser defaultUser = new DefaultUser();
            bool isDefUser = defaultUser.Authorization("amogus");
            Console.WriteLine($"is defUser {isDefUser}");

            SuperUser spUser = new SuperUser();
            bool isSpUser = spUser.Authorization("Gokhlius");
            Console.WriteLine($"is super User {isSpUser}");

            Console.ReadLine();
        }
    }
}
