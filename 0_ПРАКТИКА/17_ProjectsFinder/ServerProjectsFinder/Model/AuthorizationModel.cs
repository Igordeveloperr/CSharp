using ServerProjectsFinder.db;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ServerProjectsFinder.Model
{
    public class AuthorizationModel
    {
        public bool Authorization(string login, string password)
        {   
            var data = DataBase.DataBaseObj.GetData("SELECT * FROM user");
            foreach(var user in data.Result)
            {
                if(user["login"].Equals(login.ToLower()) && user["password"].Equals(password.ToLower()))
                {
                    return true;
                }         
            }
            return false;
        }
    }
}
