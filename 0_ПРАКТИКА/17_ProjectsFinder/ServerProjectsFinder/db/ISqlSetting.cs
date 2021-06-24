using System;
using System.Collections.Generic;
using System.Text;

namespace ServerProjectsFinder.db
{
    public interface ISqlSetting
    {
        string Server { get; }
        string User { get; }
        string Db { get; }
        string Port { get; }
        string Password { get; }
    }
}
