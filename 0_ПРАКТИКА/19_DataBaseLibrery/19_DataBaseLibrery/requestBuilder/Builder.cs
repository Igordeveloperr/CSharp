using _19_DataBaseLibrery.request;
using System;
using System.Collections.Generic;
using System.Text;

namespace _19_DataBaseLibrery.requestBuilder
{
    internal class  Builder<T>
    {
        public static Dictionary<RequestType, RequestBuilderBase<T>> RequestBuilderDictionary = new Dictionary<RequestType, RequestBuilderBase<T>>
        {
            {RequestType.SELECTALL, new SelectRequestBuilder<T>() },
            {RequestType.SELECTBYPARAMETR, new SelectRequestBuilder<T>() },
            {RequestType.SELECTBYTWOPARAMETR, new SelectRequestBuilder<T>() },
            {RequestType.INSERT, new InsertRequestBuilder<T>() },
            {RequestType.UPDATE, new UpdateBuilder<T>() },
            {RequestType.DELETE, new DeleteBuilder<T>() },
        };
    }
}
