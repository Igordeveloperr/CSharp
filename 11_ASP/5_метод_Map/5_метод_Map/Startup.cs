using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace _5_метод_Map
{
    public class Startup
    {
        private static string Name;
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // пишем путь по которому будет обрабатываться запрос и логику его обработки
            app.Map("/page", (appBuilder)=>
            {
                appBuilder.Run(async (context) =>
                {
                    await context.Response.WriteAsync("<h1>No homo</h1>");
                });
            });
            app.Map("/news", ShowNews);
            /* 
             * MapWhen - принимает в 
             * качестве параметра делегат Func<HttpContext, bool> 
             * и обрабатывает запрос, если функция, 
             * передаваемая в качестве параметра возвращает true
             */
            app.MapWhen(context => 
            {
                string login = string.Empty;
                if (context.Request.Query.ContainsKey("name"))
                {
                    login = context.Request.Query["name"];
                }
                // пускаю на страницу только гохлю шо
                if (login.Equals("gokhlia"))
                {
                    Name = login;
                    return true;
                }
                return false;
            }, ShowUserName);
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("<h1>Main Page</h1>");
            });
        }
        private void ShowNews(IApplicationBuilder builder)
        {
            builder.Run(async (context) =>
            {
                await context.Response.WriteAsync("<h1>News sho</h1>");
            });
        }
        private static void ShowUserName(IApplicationBuilder builder)
        {
            builder.Run(async (context)=>
            {
                await context.Response.WriteAsync($"<h1>User: {Name}, hello!</h1>");
            });
        }
    }
}
