using _19_DataBaseLibrery.myExceptions;
using _19_DataBaseLibrery.request;
using _19_DataBaseLibrery.requestBuilder.builderParametr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19_DataBaseLibrery.requestBuilder
{
    internal class DeleteBuilder : RequestBuilderBase
    {
        private const int MaxParamLength = 1;

        public override string BuildRequest(Parametr parameters, RequestType type)
        {
            string request = "";
            /*try
            {
                if (parameters.Count > MaxParamLength)
                    throw new RequestParametrException($"длина словаря больше допустимого значения({MaxParamLength})");
                request = $"DELETE FROM `{table}` WHERE `{parameters.ElementAt(0).Key}`='{parameters.ElementAt(0).Value}'";
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }*/
            return request;
        }
    }
}
