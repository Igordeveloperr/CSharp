using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2_Сервис_ILogger.controllers
{
    public class HomeController
    {
        private RequestDelegate Delegate;
        private readonly ILogger<HomeController> logger;
        public HomeController(ILogger<HomeController> obj)
        {
            logger = obj; 
        }
        public async Task InvokeAsync(HttpContext context)
        {
            await context.Response.WriteAsync("cho");
        }
    }
}
