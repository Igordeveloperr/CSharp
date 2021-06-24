using System;

namespace _3_FP_proj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("логин: ");
            string login = Console.ReadLine();

            Console.Write("пароль: ");
            string password = Console.ReadLine();

            User user = new User(login, password);

            DataBase db = new DataBase();
            db.AddUserToDb(user);
            Console.WriteLine(db.Users);
        }
    }
}
