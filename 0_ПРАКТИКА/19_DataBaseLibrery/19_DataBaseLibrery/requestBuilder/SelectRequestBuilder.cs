using _19_DataBaseLibrery.myExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19_DataBaseLibrery.request
{
    internal class SelectRequestBuilder<T> : RequestBuilderBase<T>
    {
        private const int MaxLengthByParametr = 1;
        private const int MaxLengthByTwoParametr = 2;
        public override string BuildRequest(string table)
        {
            string request = $"SELECT * FROM {table}";
            return request;
        }
        public override string BuildRequest(string table, Dictionary<string, T> parameters, RequestType type)
        {
            string request = "";
            if(type == RequestType.SELECTBYPARAMETR)
            {
                try
                {
                    if (parameters.Count > MaxLengthByParametr) 
                        throw new RequestParametrException($"словарь не должен быть длинее {MaxLengthByParametr}");   
                    request = $"SELECT * FROM {table} WHERE {parameters.ElementAt(0).Key} = '{parameters.ElementAt(0).Value}'";
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
            else if(type == RequestType.SELECTBYTWOPARAMETR)
            {
                try
                {
                    if (parameters.Count > MaxLengthByTwoParametr) 
                        throw new RequestParametrException($"словарь не должен быть длинее {MaxLengthByTwoParametr}");
                    request = $"SELECT * FROM {table} WHERE {parameters.ElementAt(0).Key} = '{parameters.ElementAt(0).Value}' AND {parameters.ElementAt(1).Key} = '{parameters.ElementAt(1).Value}'";
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
            return request;
        }
    }
}
