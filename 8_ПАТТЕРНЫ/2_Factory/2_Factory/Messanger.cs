using System;
using System.Collections.Generic;
using System.Text;

namespace _2_Factory
{
    class Messanger
    {
        private string UserName { get; }
        private string Password { get; }
        internal bool Connected { get; }
        internal Messanger(string name, string password)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password))
            {
                Connected = false;
                throw new ArgumentException("argument exc");
            }
            UserName = name;
            Password = password;
            Connected = ConnectToTwitter();
        }
        private void SendMessageToTwitter(Message message)
        {
            Console.WriteLine($"Сообщение отправленно: {message.Text}");
        }
        internal void SendMessage(string txt, string source, string target)
        {
            if (string.IsNullOrWhiteSpace(txt)) throw new ArgumentException(nameof(txt));
            if (string.IsNullOrWhiteSpace(source)) throw new ArgumentException(nameof(source));
            if (string.IsNullOrWhiteSpace(target)) throw new ArgumentException(nameof(target));
            if (txt.Length >= 135) throw new ArgumentException(nameof(txt), "текст не может быть больше 135 символов");
            Message message = new Message(txt, source, target);
            SendMessageToTwitter(message);
        }
        private bool ConnectToTwitter()
        {
            Console.WriteLine($"Авторизация {UserName}");
            return true;
        }
    }
}
