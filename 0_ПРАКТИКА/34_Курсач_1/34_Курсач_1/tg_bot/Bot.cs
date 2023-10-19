using System.Threading;
using System;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace _34_Курсач_1.tg_bot
{
    public class Bot : IBot
    {
        private const string TOKEN = "6093686436:AAEbQB5cyGiYZuG4V9AmjPCHto0-TGDgh70";
        public ITelegramBotClient Client { get; private set; }
        public Bot()
        {
            Client = new TelegramBotClient(TOKEN);
        }

        // запуск ботикса
        public void Start()
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            ReceiverOptions receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { }
            };

            Client.StartReceiving(
            HandlerEventAsync,
            HandlerErrorAsync,
            receiverOptions,
            cancellationToken: cts.Token);
        }

        // обработка ошибок
        public void HandlerErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            Console.WriteLine("ошибка блятьб");
        }

        //ловим события в боте
        public async void HandlerEventAsync(ITelegramBotClient client, Update update, CancellationToken ct)
        {
            Console.WriteLine("чзх ивент!");
            await client.SendTextMessageAsync(update.Message.Chat.Id, "иди нахуй");
        }
    }
}
