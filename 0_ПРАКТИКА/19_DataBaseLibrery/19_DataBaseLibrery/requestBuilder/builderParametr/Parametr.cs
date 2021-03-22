using System;
using System.Collections.Generic;
using System.Text;

namespace _19_DataBaseLibrery.requestBuilder.builderParametr
{
    public abstract class Parametr
    {
        public string Table;
        public Parametr(string table)
        {
            if (string.IsNullOrWhiteSpace(table))
                throw new ArgumentException(nameof(table));
            Table = table;
        }
    }
}
