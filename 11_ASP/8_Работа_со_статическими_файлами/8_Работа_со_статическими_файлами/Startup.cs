using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace _8_Работа_со_статическими_файлами
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            /*app.UseDefaultFiles();
            app.UseStaticFiles();*/
            app.UseFileServer(enableDirectoryBrowsing:true);
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(
                Path.Combine(Directory.GetCurrentDirectory(), @"static\html")),
                RequestPath = new PathString("/pages")
            });
            app.Map("/browse", PrintCatalog);
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Home page");
            });
        }
        private static void PrintCatalog(IApplicationBuilder app)
        {
            app.UseDirectoryBrowser();
        }
    }
}
