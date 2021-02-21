using _17_ProjectsFinder.Send.Settings;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Windows;

namespace _17_ProjectsFinder.Send
{
    public class AuthorizationRequest: Request
    {
        public const string type = "authorization";
        public string Login { get; }
        public string Password { get; }
        public AuthorizationRequest(string login, string password) : base(type)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("bad data!");
            }
            Login = login;
            Password = password;
        }
    }
}
