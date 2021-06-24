using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6_Определение_компонентов
{
    public class TokenMiddleware
    {
        private RequestDelegate Next;
        private string Pattern;
        public TokenMiddleware(RequestDelegate next, string pattern)
        {
            if(next != null)
            {
                Next = next;
                Pattern = pattern;
            }
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var token = context.Request.Query["token"];
            if (!token.Equals(Pattern))
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync($"<h1>Error; Token {Pattern} 403</h1>");
            }
            else
            {
                await Next(context);
            }
        }
    }
}
