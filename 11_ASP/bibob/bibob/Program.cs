using bibob;
using Microsoft.AspNetCore.Identity;
using System;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
List<User> users = new List<User>();

app.Run(async (context) =>
{
    var path = context.Request.Path;
    if (path.Equals("/reg"))
    {
        var form = context.Request.Form;
        User person = new User(form["name"], Convert.ToInt32(form["age"]));
        users.Add(person);
        context.Response.Redirect("/list",true);
    }
    else if (path.Equals("/list"))
    {
        context.Response.ContentType = "text/html; charset=utf-8";
        string output = "";
        for(int i = 0; i < users.Count; i++)
        {
            output = $"<p>{output}{users[i].Name} ---> {users[i].Age}<p><br>";
        }
        output = $"{output}<br><a href='/'>Back</a>";
        await context.Response.WriteAsync(output,Encoding.UTF8);
    }
    else
    {
        context.Response.ContentType = "text/html; charset=utf-8";
        await context.Response.SendFileAsync("index.html");
    }
});

app.Run();
