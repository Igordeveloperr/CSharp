using System;
using System.Collections.Generic;
using System.Text;

namespace _3_FP_proj
{
    class DataBase
    {
        private List<User> users = new List<User>();
        public string  Users
        {
            get
            {
                string outStr = "";
                foreach(User user in users)
                {
                    outStr += $"{user.Login} - {user.Password}";
                }
                return outStr;
            }
        }

        public void AddUserToDb(User obj)
        {
            if (obj != null)
            {
                this.users.Add(obj);
            }
        }
    }
}
