using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace _2_Обработка_запросов
{
    public class Startup
    {
        string title = "Huba buba";
        // регистрирует все сервисы, которые будут юзаться в приложухе
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // метод обработки запроса
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // компонент для работы с статическими файлами
            app.UseStaticFiles();
            // это пожилая маршрутизация
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
                endpoints.MapGet("/news", async context => {
                    await context.Response.WriteAsync($"news - {title}");
                });
            });
        }
    }
}
