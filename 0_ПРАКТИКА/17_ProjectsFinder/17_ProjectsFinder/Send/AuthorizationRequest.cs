using _17_ProjectsFinder.Send.Settings;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Windows;

namespace _17_ProjectsFinder.Send
{
    public class AuthorizationRequest: Request
    {
        private const string type = "authorization";
        private NetworkStream Stream;
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
        public async void SendRequest()
        {
            string jsonData = JsonSerializer.Serialize<object>(this);
            TcpClient Client = new TcpClient();
            byte[] data = Encoding.UTF8.GetBytes(jsonData);
            await Client.ConnectAsync(Setting.Ip, Setting.Port);
            Stream = Client.GetStream();
            Stream.Write(data, 0, data.Length);
            Stream.Close();
            Client.Close();
        }
    }
}
