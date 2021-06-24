using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _7_конвейер_обработки_запросов
{
    // класс основного роутера
    public class MyRoutingMiddleware
    {
        private RequestDelegate Next;
        public MyRoutingMiddleware(RequestDelegate next)
        {
            Next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            string path = context.Request.Path.Value.ToLower();
            if (path.Equals("/"))
            {
                await context.Response.WriteAsync("<h1 style='color:green;'>Home Page</h1>");
            }
            else if (path.Equals("/ard"))
            {
                await context.Response.WriteAsync("<h1 style='color:red;'>Ardubina</h1>");
            }
            else
            {
                context.Response.StatusCode = 404;
            }
        }
    }
}
