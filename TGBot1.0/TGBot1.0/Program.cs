using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Newtonsoft.Json;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using TGBot1._0;
using Telegram.Bot.Types.ReplyMarkups;
using System.Collections.Generic;

namespace TelegramBotExperiments
{

    class Program
    {
        private static string token = "6093686436:AAEbQB5cyGiYZuG4V9AmjPCHto0-TGDgh70";
        static ITelegramBotClient bot = new TelegramBotClient(token);

        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var msg = update.Message;
                if(msg.Text != null)
                {
                    if (msg.Text.Equals(Command.Start))
                    {
                        await botClient.SendTextMessageAsync(msg.Chat,Answer.Welcome);
                    }
                }
                await botClient.CopyMessageAsync(-1001448165623, update?.Message.Chat, update.Message.MessageId);

                var keyboard = new ReplyKeyboardMarkup(
                    new List<KeyboardButton>
                    {
                        new KeyboardButton("✅"), new KeyboardButton("❌") 
                    }
                );

                await botClient.SendTextMessageAsync(
                    chatId:-1001448165623,
                    text:Answer.DropPost
                    
                );
            }
        }

        public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(JsonConvert.SerializeObject(exception));
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Запущен бот " + bot.GetMeAsync().Result.FirstName);

            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { }, // receive all update types
            };
            bot.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken
            );
            Console.ReadLine();
        }
    }
}