using System;
using System.Collections.Generic;
using System.Text;

namespace _3_FP_proj
{
    class User
    {
        private string login;
        private string password;
        public string Login 
        {
            get
            {
                return this.login;
            }
        }
        public string Password 
        {
            get
            {
                return this.password;
            }
        }

        public User(string login, string password)
        {
            if (!string.IsNullOrWhiteSpace(login) && !string.IsNullOrWhiteSpace(password))
            {
                this.login = login;
                this.password = password;
                Console.WriteLine("Вы успешно вошли!");
            }
            else
            {
                Console.WriteLine("Введен неверный формат данных!!!");
            }
        }
    }
}
