using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace _9_HTTPS
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // настраиваю параметры переадресации
            services.AddHttpsRedirection(serv =>
            {
                serv.RedirectStatusCode = StatusCodes.Status307TemporaryRedirect;
                serv.HttpsPort = 44313;
            });
            services.AddHsts(options =>
            {
                options.Preload = true; // использовать список preload доменов “»ѕј Ѕ≈«ќѕј—Ќќ—“№  ќ–ќ„Ё
                options.IncludeSubDomains = true; // примен€ть действие ко всем доменам
                options.MaxAge = TimeSpan.FromDays(60); // максимальное действие заголовка
                // ну и сами домены
                options.ExcludedHosts.Add("us.example.com");
                options.ExcludedHosts.Add("www.example.com");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts(); // перевожу сервер на HTTPS после прин€ти€ первого http запроса
            }

            app.UseRouting();
            app.UseHttpsRedirection(); // переадресую свою приложуху на https
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
