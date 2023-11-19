using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;

namespace _36_Курсач_бот.tg_bot
{
    public interface IBotKeyBoard
    {
        public ReplyMarkupBase Create();
    }
}
