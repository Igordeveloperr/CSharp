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
        public ReplyMarkupBase Create(string teapotState)
        {
            List<KeyboardButton> btns = new List<KeyboardButton>();
            btns.Add(new KeyboardButton("Вкл чайник"));
            btns.Add(new KeyboardButton("Температура"));
            btns.Add(new KeyboardButton("Влажность"));
            ReplyKeyboardMarkup keyBoard = new ReplyKeyboardMarkup(btns);
            keyBoard.ResizeKeyboard = true;
            return keyBoard;
        }
    }
}
