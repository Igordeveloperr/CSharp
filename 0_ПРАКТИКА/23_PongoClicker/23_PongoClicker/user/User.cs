using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_PongoClicker.user
{
    internal abstract class User
    {
        protected string _login;
        protected string _password;
        protected int _lvl;
        protected int _money;
        public User(string login, string password)
        {
            _login = login;
            _password = password;
        }
    }
}
