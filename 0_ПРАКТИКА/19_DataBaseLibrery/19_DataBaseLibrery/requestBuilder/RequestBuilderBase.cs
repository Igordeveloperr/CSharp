using System;
using System.Collections.Generic;
using System.Text;

namespace _19_DataBaseLibrery.request
{
    internal abstract class RequestBuilderBase<T>
    {
        public abstract string BuildRequest(string table);
        public abstract string BuildRequest(string table, Dictionary<string, T> parameters, RequestType type);
    }
}
