using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace _36_Курсач_бот.tg_bot
{
    internal interface IBot
    {
        public void Start();
        public void HandlerErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken);
        public void HandlerEventAsync(ITelegramBotClient client, Update update, CancellationToken ct);
    }
}
