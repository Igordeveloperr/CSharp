using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace TGBot1._0
{
    internal static class KeyBoard
    {
        public static ReplyKeyboardMarkup Board { get; } = new ReplyKeyboardMarkup(new KeyboardButton("test"));
       
    }
}
