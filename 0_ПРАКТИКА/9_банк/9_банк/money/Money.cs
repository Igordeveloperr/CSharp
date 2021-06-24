using System;
using System.Collections.Generic;
using System.Text;
using _9_банк.Interfaces;

namespace _9_банк.money
{
    public abstract class Money<T> : ICommand<T>
    {
        public static Dictionary<string, Money<T>> Command = new Dictionary<string, Money<T>>
        {
            {"add", new AddMoney<T>() },
            {"toff", new TakeOffMoney() }
        };
        protected decimal Cache = 0;
        public abstract void CallCommand(decimal value);

        public void SelectCommand(string command, T arg)
        {
            throw new NotImplementedException();
        }
    }
}
