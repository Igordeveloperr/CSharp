using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _9_Обработка_ошибок
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            env.EnvironmentName = "Production";
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/error");
            }
            //app.UseStatusCodePages();
            app.Map("/error", app =>
            {
                app.Run(async context =>
                {
                    await context.Response.WriteAsync("div by zero!");
                });
            });
            app.Map("/home", app => app.Run(async context =>
            {
                int y = 9212;
                int x = y / 10;
                await context.Response.WriteAsync($"{x}");
            }));
        }
    }
}
