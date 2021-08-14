using _5_Создание_компонентов_middleware.middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _5_Создание_компонентов_middleware
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Map("/user", ValidateUserData);
            app.Run(async context =>
            {
                await context.Response.WriteAsync("home page");
            });
        }
        private static void ValidateUserData(IApplicationBuilder app)
        {
            app.UseMiddleware<UserMiddleware>();
            app.Run(async context =>
            {
                await context.Response.WriteAsync("this is your prifile");
            });
        }
    }
}
