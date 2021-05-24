using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1_Маршрутизация.middlewares
{
    public class TestMiddleware
    {
        private const string CurrentUri = "/test.html";
        private readonly RequestDelegate Delegate;
        private readonly IApplicationBuilder App;
        public TestMiddleware(RequestDelegate requestDelegate, IApplicationBuilder app)
        {
            if (requestDelegate == null || app == null)
                throw new NullReferenceException("парметры имеют значение null");
            Delegate = requestDelegate;
            App = app;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            string requestPath = context.Request.Path.Value;
            if (requestPath.Equals(CurrentUri))
            {
                context.Response.StatusCode = 200;
                var id = context.Request.Query["testId"];

            }
        }
    }
}
