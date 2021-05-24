using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _11_свои_сервисы.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace _11_свои_сервисы
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // добовляю возможность юзать функционал gitHub сендлера
            services.AddTransient<EmailMessageSendler>();
            services.AddTransient<TimeService>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, EmailMessageSendler sendler, TimeService time)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    context.Response.ContentType = "text/html; charset=utf-8";
                    // вызываю мои методы пожилые
                    await sendler.Send();
                    await context.Response.WriteAsync(time.GetTime());
                });
            });
        }
    }
}
