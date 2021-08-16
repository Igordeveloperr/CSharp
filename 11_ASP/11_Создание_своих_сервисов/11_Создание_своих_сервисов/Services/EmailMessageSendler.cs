using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_Создание_своих_сервисов.Services
{
    public class EmailMessageSendler : IMessageSendler
    {
        public string Send()
        {
            return "sending message to email.";
        }
    }
}
