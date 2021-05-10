using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace _3_Метод_Run
{
    public class Startup
    {
        private IApplicationBuilder App;
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
            // обработка переадресации
            app.UseRouting();
            app.UseEndpoints( endPoints =>
            {
                endPoints.MapGet("/", Handle);    
            });
            // обработка запроса с помощью метода Run
            app.Run(async (context)=>
            {
                Redirection(context, app);
            });
        }
        // метод, который получает данные о запросе
        private async Task Handle(HttpContext context)
        {
            string host = context.Request.Host.Value; // хост, к которому обращается юзер
            string path = context.Request.Path.Value; // путь запроса
            string query = context.Request.QueryString.Value; // параметры строки запроса
            context.Response.ContentType = "text/html;charset=utf-8"; // настройка кодировки
            string output = $"<h1>Хост:{host}</h1><br><h1>Путь:{path}</h1><br><h1>Запрос:{query}</h1>";
            await context.Response.WriteAsync(output);
        }
        // метод переадресации
        private void Redirection(HttpContext context, IApplicationBuilder app)
        {
            string basePath = "/";
            string requestPath = context.Request.Path.Value;
            if (requestPath != basePath)
            {
                var options = new RewriteOptions();
                options.AddRewrite(requestPath, basePath, false);
                app.UseRewriter(options);
            }
        }
    }
}
