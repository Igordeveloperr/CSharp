using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot;
using _36_Курсач_бот.logger;
using System.Reflection.Metadata;

namespace _36_Курсач_бот.tg_bot
{
    public class Bot : IBot
    {
        const string SERVER_URL = "http://192.168.1.151";
        private const string TOKEN = "6093686436:AAEbQB5cyGiYZuG4V9AmjPCHto0-TGDgh70";
        private IBotKeyBoard _botKeyBoard;
        private bool teapotIsOn = false;
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
            Console.WriteLine("Бот стартанул...");
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
                try
                {
                    if (msg == "/start")
                    {
                        await client.SendTextMessageAsync(
                            chatId: chatId,
                            text: "Я жив",
                            replyMarkup: _botKeyBoard.Create(),
                            cancellationToken: ct
                        );
                    }
                    else if (msg == "✅ чайник")
                    {
                        using (HttpClient httpClient = new HttpClient())
                        {
                            // определяем данные запроса
                            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"{SERVER_URL}/teapotOn");
                            // выполняем запрос
                            HttpResponseMessage response = await httpClient.SendAsync(request);
                            string content = await response.Content.ReadAsStringAsync();
                            await client.SendTextMessageAsync(
                                chatId: chatId,
                                text: $"Состояние чайника: {content}",
                                replyMarkup: _botKeyBoard.Create(),
                                cancellationToken: ct
                            );

                            if (teapotIsOn == false)
                            {
                                teapotIsOn = true;
                                for (int i = 0; i < 300; i++)
                                {
                                    if (teapotIsOn == false) break;
                                    await Task.Delay(1000);
                                }
                                teapotIsOn = false;
                                using HttpRequestMessage request1 = new HttpRequestMessage(HttpMethod.Get, $"{SERVER_URL}/teapotOff");
                                HttpResponseMessage response1 = await httpClient.SendAsync(request1);
                                string content1 = await response1.Content.ReadAsStringAsync();
                                await client.SendTextMessageAsync(
                                    chatId: chatId,
                                    text: $"Чаек ГОТОВ! ☕️🍩",
                                    replyMarkup: _botKeyBoard.Create(),
                                    cancellationToken: ct
                                );
                            }
                            else
                            {
                                await client.SendTextMessageAsync(
                                    chatId: chatId,
                                    text: $"Чайник уже включен ☕",
                                    replyMarkup: _botKeyBoard.Create(),
                                    cancellationToken: ct
                                );
                            }
                        }
                    }
                    else if (msg == "❌ чайник")
                    {
                        teapotIsOn = false;
                        using (HttpClient httpClient = new HttpClient())
                        {
                            // определяем данные запроса
                            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"{SERVER_URL}/teapotOff");
                            // выполняем запрос
                            HttpResponseMessage response = await httpClient.SendAsync(request);
                            string content = await response.Content.ReadAsStringAsync();
                            await client.SendTextMessageAsync(
                                chatId: chatId,
                                text: $"Состояние чайника: {content}",
                                replyMarkup: _botKeyBoard.Create(),
                                cancellationToken: ct
                            );
                        }
                    }
                    else if (msg == "🌡 температура")
                    {
                        using (HttpClient httpClient = new HttpClient())
                        {
                            // определяем данные запроса
                            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"{SERVER_URL}/temperature");
                            // выполняем запрос
                            HttpResponseMessage response = await httpClient.SendAsync(request);
                            string content = await response.Content.ReadAsStringAsync();
                            await client.SendTextMessageAsync(
                                chatId: chatId,
                                text: $"Температура в комнате: {content}℃",
                                replyMarkup: _botKeyBoard.Create(),
                                cancellationToken: ct
                            );
                        }
                    }
                    else if (msg == "🌨 влажность")
                    {
                        using (HttpClient httpClient = new HttpClient())
                        {
                            // определяем данные запроса
                            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, $"{SERVER_URL}/humidity");
                            // выполняем запрос
                            HttpResponseMessage response = await httpClient.SendAsync(request);
                            string content = await response.Content.ReadAsStringAsync();
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
                catch (Exception e)
                {
                    await client.SendTextMessageAsync(
                        chatId: chatId,
                        text: "Сервер не отвечает :)",
                        replyMarkup: _botKeyBoard.Create(),
                        cancellationToken: ct
                    );
                }
            }
        }
    }
}
