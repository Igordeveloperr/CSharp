using _19_DataBaseLibrery.myExceptions;
using _19_DataBaseLibrery.request;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace _19_DataBaseLibrery.requestBuilder
{
    internal class InsertRequestBuilder<T> : RequestBuilderBase<T>
    {   
        private const int MaxDictionaryLength = 8;
        private const string NullSqlSyntax = "NULL";
        public override string BuildRequest(string request)
        {
            throw new EmptyMethodException("Команда INSERT используется только с методом, который принимает словарь в параметры!");
        }

        public override string BuildRequest(string table, Dictionary<string, T> parameters, RequestType type)
        {
            string request = "";
            string into = "";
            string values = "";
            try
            {
                if (parameters.Count > MaxDictionaryLength) 
                    throw new RequestParametrException("длина словаря больше допустимого значения(8)");
                foreach(var parametr in parameters)
                {
                    into += $"`{parametr.Key}`,";
                    if (parametr.Value.Equals(NullSqlSyntax))
                    {
                        values += $"{parametr.Value},";
                    }
                    else
                    {
                        values += $"'{parametr.Value}',";
                    }
                }
                request = $"INSERT INTO `{table}` ({into.Trim(new Char[] { ',' })}) VALUES ({values.Trim(new Char[] { ',' })})";
                Console.WriteLine(request);
            }  
            catch(Exception e)
            {
                throw new Exception(e.Message);                
            }
            return request;
        }
    }
}
