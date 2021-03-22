using _19_DataBaseLibrery.myExceptions;
using _19_DataBaseLibrery.requestBuilder.builderParametr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19_DataBaseLibrery.request
{
    internal class SelectRequestBuilder : RequestBuilderBase
    {
        public override string BuildRequest(Parametr parameters, RequestType type)
        {
            SelectParametr obj = (SelectParametr)parameters; 
            string request = type == RequestType.SELECTALL ? request = $"SELECT * FROM `{obj.Table}`" : "";
            if (type == RequestType.SELECTBYPARAMETR)
            {
                request = $"SELECT * FROM `{obj.Table}` WHERE `{obj.SorCategory}` = '{obj.SortValue}'";
            }
            else if (type == RequestType.SELECTBYTWOPARAMETR)
            {

                request = $"SELECT * FROM `{obj.Table}` WHERE `{obj.SorCategory}` = '{obj.SortValue}' AND `{obj.SorCategorySecond}` = '{obj.SortValueSecond}'";
            }
            Console.WriteLine(request);
            return request;
        }
    }
}
