using _19_DataBaseLibrery.myExceptions;
using _19_DataBaseLibrery.request;
using _19_DataBaseLibrery.requestBuilder.builderParametr;
using System;
using System.Collections.Generic;
using System.Text;

namespace _19_DataBaseLibrery.requestBuilder
{
    internal class UpdateBuilder : RequestBuilderBase
    {
        private const int MaxColumnLength = 9;
        private const int MaxExplodedLength = 2;

        public override string BuildRequest(Parametr parameters, RequestType type)
        {
            string request = "";
            string set = "";
            string value = "";
            string resultSet = "";
            string[] exploded = null;
            /*try
            {
                if (parameters.Count > MaxColumnLength)
                    throw new RequestParametrException($"длина больше допустимого значения({MaxColumnLength})");
                foreach(var parametr in parameters)
                {
                    bool flag = parametr.Key.Split("/")[0].ToLower().Equals("sort");
                    if (flag)
                    {
                        exploded = parametr.Key.Split("/");
                        continue;
                    }
                    set = $"`{parametr.Key}`";
                    value = $"'{parametr.Value}',";
                    resultSet += $"{set}={value}";
                }
                request = $"UPDATE `{table}` SET {resultSet.Trim(new Char[] { ',' } )} WHERE `{exploded?[1]}`='{parameters[$"{exploded?[0]}/{exploded?[1]}"]}'";
                Console.WriteLine(request);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }*/
            return request;
        }
    }
}
