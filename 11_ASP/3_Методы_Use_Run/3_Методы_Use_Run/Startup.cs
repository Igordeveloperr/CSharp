using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3_Методы_Use_Run
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            int x = 10;
            int y = 50;
            app.Use(async (context, nextComponent) =>
            {
                await context.Response.WriteAsync(Convert.ToString(x * y));
                await nextComponent?.Invoke();
            });
            app.Run(async context =>
            {
                await context.Response.WriteAsync(" - I'm last middleware component");
            });
        }
    }
}
