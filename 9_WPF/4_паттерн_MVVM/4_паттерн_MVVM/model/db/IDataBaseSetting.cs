using System;
using System.Collections.Generic;
using System.Text;

namespace _4_паттерн_MVVM.model.db
{
    interface IDataBaseSetting
    {
        string Host { get; }
        string User { get; }
        string Db { get; }
        string Port { get; }
        string Possword { get; }
    }
}
