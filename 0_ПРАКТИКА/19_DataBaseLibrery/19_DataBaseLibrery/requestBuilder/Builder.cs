using _19_DataBaseLibrery.request;
using System;
using System.Collections.Generic;
using System.Text;

namespace _19_DataBaseLibrery.requestBuilder
{
    internal class  Builder
    {
        public static Dictionary<RequestType, RequestBuilderBase> RequestBuilderDictionary = new Dictionary<RequestType, RequestBuilderBase>
        {
            {RequestType.SELECTALL, new SelectRequestBuilder() },
            {RequestType.SELECTBYPARAMETR, new SelectRequestBuilder() },
            {RequestType.SELECTBYTWOPARAMETR, new SelectRequestBuilder() },
            {RequestType.INSERT, new InsertRequestBuilder() },
            {RequestType.UPDATE, new UpdateBuilder() },
            {RequestType.DELETE, new DeleteBuilder() },
        };
    }
}
