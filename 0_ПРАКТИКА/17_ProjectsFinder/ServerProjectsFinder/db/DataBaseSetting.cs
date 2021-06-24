using System;
using System.Collections.Generic;
using System.Text;

namespace ServerProjectsFinder.db
{
    public class DataBaseSetting : ISqlSetting
    {
        public string Server { get; } = "localhost";

        public string User { get; } = "root";

        public string Db { get; } = "projectsfinder";

        public string Port { get; } = "3306";

        public string Password { get; } = "";
    }
}
