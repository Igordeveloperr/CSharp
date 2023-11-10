using _36_Курсач_бот.tg_bot;
using Telegram.Bot.Types.ReplyMarkups;

IBotKeyBoard keyBoard = new ControlKeyBoard();
IBot bot = new Bot(keyBoard);
bot.Start();
Console.ReadLine();
