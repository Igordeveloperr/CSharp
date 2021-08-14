using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4_Методы_Map_MapWhen
{
    public class Startup
    {
        private static string _currentId = string.Empty;
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Map("/news", PrintNewsPage);
            app.Map("/about", PrintAboutPage);
            app.Map("/profile", profile =>
            {
                profile.Map("/img", ViewProfileImage);
                profile.Map("/desc", ViewProfileDescription);
                profile.Run(async context => 
                {
                    await context.Response.WriteAsync("<a href='/profile/img'>image page</a>");
                    await context.Response.WriteAsync("</br>");
                    await context.Response.WriteAsync("<a href='/profile/desc'>description page</a>");
                });
            });
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Home page");
            });
        }
        private static void PrintNewsPage(IApplicationBuilder app)
        {
            app.MapWhen(context =>
            {
                bool flag = false;
                List<int> listId = new List<int>() { 1, 5, 10, 15, 20 };
                foreach (int id in listId)
                {
                    string pasreId = Convert.ToString(id);
                    if (context.Request.Query["id"].Equals(pasreId))
                    {
                        _currentId = context.Request.Query["id"];
                        flag = true;
                    }
                }
                return flag;
            }, HighlightUnusualNews);
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync(Convert.ToString(context.Response.StatusCode));
                await next?.Invoke();
            });
            app.Run(async context => 
            {
                await context.Response.WriteAsync(" - News Page");
            });
        }
        private static void PrintAboutPage(IApplicationBuilder app) 
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync(" - About Page");
            });
        }
        private static void ViewProfileImage(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Your profile image");
            });
        }
        private static void ViewProfileDescription(IApplicationBuilder app)
        {
            int growth = 0;
            int age = 0;
            int weight = 0;
            app.Use(async (context, next) =>
            {
                growth = 150;
                await context.Response.WriteAsync($"User have growth:{growth}");
                await next?.Invoke();
            });
            app.Use(async (context, next) =>
            {
                age = 17;
                await next?.Invoke();
                weight = 56;
            });
            app.Run(async context => 
            {
                await context.Response.WriteAsync($" - age * weight = {age * weight} - ");
                weight = 56;
                await context.Response.WriteAsync($" - User info: age:{age}; weight:{weight};");
            });
        }
        private static void HighlightUnusualNews(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync($"<p style='background:green;color:white;'>{_currentId}</p>");
            });
        }
    }
}
