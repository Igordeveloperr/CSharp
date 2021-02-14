using System;
using System.Collections.Generic;
using System.Text;

namespace _9_банк.Interfaces
{
    interface ICommand<T>
    {
        public void SelectCommand(string command, T arg);
    }
}
