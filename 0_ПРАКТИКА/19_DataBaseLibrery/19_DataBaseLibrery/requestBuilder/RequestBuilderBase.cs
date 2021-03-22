using _19_DataBaseLibrery.requestBuilder.builderParametr;
using System;
using System.Collections.Generic;
using System.Text;

namespace _19_DataBaseLibrery.request
{
    internal abstract class RequestBuilderBase
    {
        public abstract string BuildRequest(Parametr parameters, RequestType type);
    }
}
