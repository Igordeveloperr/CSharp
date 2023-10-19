using System.Threading;
using System;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;

namespace _34_Курсач_1.tg_bot
{
    public class Bot : IBot
    {
        private IBotKeyBoard _botKeyBoard;
        private const string TOKEN = "6093686436:AAEbQB5cyGiYZuG4V9AmjPCHto0-TGDgh70";
        public ITelegramBotClient Client { get; private set; }
        public Bot(IBotKeyBoard keyBoar)
        {
            _botKeyBoard = keyBoar;
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
            Console.WriteLine(exception);
        }

        //ловим события в боте
        public async void HandlerEventAsync(ITelegramBotClient client, Update update, CancellationToken ct)
        {
            Console.WriteLine("чзх ивент!");
            if(update.Message != null)
            {
                long chatId = update.Message.Chat.Id;
                string msg = update.Message.Text.ToLower();
                if (msg == "вкл чайник")
                {
                    // TODO: отправить команду ESP
                    Console.WriteLine("чайник");
                }
                else if (msg == "температура")
                {
                    // TODO: отправить команду ESP
                    Console.WriteLine("Датчик");
                }
                else
                {
                    await client.SendTextMessageAsync(
                        chatId: chatId,
                        text: "Выберите команду",
                        replyMarkup: _botKeyBoard.Create(),
                        cancellationToken: ct
                    );
                }
            }
        }
    }
}
