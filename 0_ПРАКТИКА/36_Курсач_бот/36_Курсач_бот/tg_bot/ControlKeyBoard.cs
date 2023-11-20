using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;

namespace _36_Курсач_бот.tg_bot
{
    public class ControlKeyBoard : IBotKeyBoard
    {
        public ReplyMarkupBase Create()
        {
            List<List<KeyboardButton>> btns = new List<List<KeyboardButton>>()
            {
                new List<KeyboardButton>(){ new KeyboardButton("✅ чайник"), new KeyboardButton("❌ чайник") },
                new List<KeyboardButton>(){ new KeyboardButton("🌡 температура"), new KeyboardButton("🌨 влажность") },
            };
            ReplyKeyboardMarkup keyBoard = new ReplyKeyboardMarkup(btns);
            keyBoard.ResizeKeyboard = true;
            return keyBoard;
        }
    }
}
