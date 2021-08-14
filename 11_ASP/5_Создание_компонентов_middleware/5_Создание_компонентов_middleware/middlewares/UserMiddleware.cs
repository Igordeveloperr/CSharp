using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _5_Создание_компонентов_middleware.middlewares
{
    public class UserMiddleware
    {
        private readonly RequestDelegate _request;
        public UserMiddleware(RequestDelegate request)
        {
            _request = request;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            string userName = context.Request.Query["name"];
            string currentUserName = "gokhlia";
            if(userName == null || !(userName.Equals(currentUserName)))
            {
                await context.Response.WriteAsync("You have invalid user name");
            }
            else
            {
                await _request?.Invoke(context);
            }
        }
    }
}
