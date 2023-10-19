using Microsoft.VisualBasic;
using System.Threading;
using System;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace _34_Курсач_1.tg_bot
{
    public interface IBot
    {
        public void Start();
        public void HandlerErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken);
        public void HandlerEventAsync(ITelegramBotClient client, Update update, CancellationToken ct);
    }
}
