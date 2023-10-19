using System.Collections.Generic;
using Telegram.Bot.Types.ReplyMarkups;

namespace _34_Курсач_1.tg_bot
{
    public class ControlKeyBoard : IBotKeyBoard
    {
        public ReplyMarkupBase Create()
        {
            List<KeyboardButton> btns = new List<KeyboardButton>();
            btns.Add(new KeyboardButton("Вкл чайник"));
            btns.Add(new KeyboardButton("Температура"));
            ReplyKeyboardMarkup keyBoard = new ReplyKeyboardMarkup(btns);
            keyBoard.ResizeKeyboard = true;
            return keyBoard;
        }
    }
}
