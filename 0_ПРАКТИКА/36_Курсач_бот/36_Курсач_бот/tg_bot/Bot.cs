using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot;
using _36_Курсач_бот.logger;

namespace _36_Курсач_бот.tg_bot
{
    public class Bot : IBot
    {
        const string SERVER_URL = "http://192.168.0.127";
        private const string TOKEN = "6093686436:AAEbQB5cyGiYZuG4V9AmjPCHto0-TGDgh70";
        private IBotKeyBoard _botKeyBoard;
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(exception.Message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        //ловим события в боте
        public async void HandlerEventAsync(ITelegramBotClient client, Update update, CancellationToken ct)
        {
            if (update.Message != null)
            {
                long chatId = update.Message.Chat.Id;
                string msg = update.Message.Text.ToLower();
                CommandLogger.Log(msg);
                if (msg == "вкл чайник")
                {
                    using (HttpClient httpClient = new HttpClient())
                    {
                        // определяем данные запроса
                        using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"{SERVER_URL}/teapotOn");
                        // выполняем запрос
                        HttpResponseMessage response = await httpClient.SendAsync(request);
                        string content = await response.Content.ReadAsStringAsync();
                        InputDataLogger.Log(content);
                        await client.SendTextMessageAsync(
                            chatId: chatId,
                            text: $"Состояние чайника: {content}",
                            replyMarkup: _botKeyBoard.Create(),
                            cancellationToken: ct
                        );
                    }

                }
                else if (msg == "температура")
                {
                    using(HttpClient httpClient = new HttpClient())
                    {
                        // определяем данные запроса
                        using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"{SERVER_URL}/temperature");
                        // выполняем запрос
                        HttpResponseMessage response = await httpClient.SendAsync(request);
                        string content = await response.Content.ReadAsStringAsync();
                        InputDataLogger.Log(content);
                        await client.SendTextMessageAsync(
                            chatId: chatId,
                            text: $"Температура в комнате: {content}℃",
                            replyMarkup: _botKeyBoard.Create(),
                            cancellationToken: ct
                        );
                    }
                }
                else if (msg == "влажность")
                {
                    using (HttpClient httpClient = new HttpClient())
                    {
                        // определяем данные запроса
                        using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"{SERVER_URL}/humidity");
                        // выполняем запрос
                        HttpResponseMessage response = await httpClient.SendAsync(request);
                        string content = await response.Content.ReadAsStringAsync();
                        InputDataLogger.Log(content);
                        await client.SendTextMessageAsync(
                            chatId: chatId,
                            text: $"Влажность воздуха: {content}%",
                            replyMarkup: _botKeyBoard.Create(),
                            cancellationToken: ct
                        );
                    }
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
