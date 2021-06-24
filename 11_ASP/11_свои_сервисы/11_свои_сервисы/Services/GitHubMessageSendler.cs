using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_свои_сервисы.Services
{
    public class GitHubMessageSendler : IMessageSendler
    {
        public string Send()
        {
            return "You are sending message from GitHub";
        }
    }
}
