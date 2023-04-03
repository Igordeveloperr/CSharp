using Newtonsoft.Json;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

// тупа вывод ошибки
async Task HandlerErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
{
    Console.WriteLine(JsonConvert.SerializeObject(exception));
}

//ловим события в боте
async Task HandlerEventAsync(ITelegramBotClient client, Update update, CancellationToken ct)
{
    Console.WriteLine(JsonConvert.SerializeObject(update.Type));
    if(update.Type == UpdateType.Message)
    {
        InlineKeyboardMarkup keyboard = new(new[]
        {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("✅","true"),
            },
            new[]
            {
                InlineKeyboardButton.WithCallbackData("❌","false"),
            },
        });
        await client.CopyMessageAsync(-1001448165623, update.Message.From.Id, update.Message.MessageId, replyMarkup: keyboard);
        await client.SendTextMessageAsync(update.Message.From.Id,"Ваш пост улетел в предложку!");
        return;
    }

    if (update.Type == UpdateType.Message && update?.Message?.Text != null)
    {
        await MessageHandler(client, update.Message);
        return;
    }
    if(update.Type == UpdateType.CallbackQuery)
    {
        await CallbackQueryHandler(client,update.CallbackQuery);
        return;
    }
}

async Task CallbackQueryHandler(ITelegramBotClient client,CallbackQuery query)
{
    string data = query?.Data;
    if (data.Equals("true"))
    {
        await client.CopyMessageAsync(-1001875574459,-1001448165623, query.Message.MessageId);
    }

    await client.DeleteMessageAsync(-1001448165623,query.Message.MessageId);
}

// обработка текстовых сообщений
async Task MessageHandler(ITelegramBotClient client, Message message)
{
    if (message.Text.Equals("/start"))
    {
        await client.SendTextMessageAsync(message.From.Id, "Здорова камень! Отправь пост который хочешь выложить в ТГ канал.");
    }
}

string token = "6093686436:AAEbQB5cyGiYZuG4V9AmjPCHto0-TGDgh70";
ITelegramBotClient client = new TelegramBotClient(token);
CancellationTokenSource cts = new CancellationTokenSource();
ReceiverOptions receiverOptions = new ReceiverOptions
{
    AllowedUpdates = { }
};

client.StartReceiving(
    HandlerEventAsync,
    HandlerErrorAsync,
    receiverOptions,
    cancellationToken:cts.Token);

Console.ReadLine();
cts.Cancel();