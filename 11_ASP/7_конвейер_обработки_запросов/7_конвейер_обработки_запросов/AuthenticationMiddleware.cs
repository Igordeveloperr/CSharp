using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _7_конвейер_обработки_запросов
{
    // класс авторизации пользователей
    public class AuthenticationMiddleware
    {
        private const string QueryKey = "userKey";
        private RequestDelegate Next;
        public AuthenticationMiddleware(RequestDelegate next)
        {
            Next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            string token = context.Request.Query[QueryKey];
            if (string.IsNullOrWhiteSpace(token))
                context.Response.StatusCode = 403; // доступ к ресурсу запрещен
            else
            {
                context.Response.StatusCode = 200;
                await Next(context);
            }
        }
    }
}
