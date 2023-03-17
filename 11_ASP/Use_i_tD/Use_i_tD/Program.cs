var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
string date = string.Empty;

async Task GetDate(HttpContext context, Func<Task> next)
{
    context.Response.ContentType = "text/html charset=utf8";
    string path = context.Request.Path.Value?.ToLower();
    if (path.Equals("/date"))
    {
        date = DateTime.Now.ToShortDateString();
        await context.Response.WriteAsync($"<h4>{date}</h4>");
    }
    else
    {
        await next.Invoke();
    }
}

async Task GetTime(HttpContext context, Func<Task>next)
{
    context.Response.ContentType = "text/html charset=utf8";
    string path = context.Request.Path.Value?.ToLower();
    if (path.Equals("/time"))
    {
        date = DateTime.Now.ToShortTimeString();
        await context.Response.WriteAsync($"<h4>{date}</h4>");
    }
    else
    {
        await next.Invoke();
    }
}

async Task GetMainPage(HttpContext context)
{
    context.Response.ContentType = "text/html charset=utf8";
    await context.Response.SendFileAsync("index.html");
}
app.UseWhen(
    context=>context.Request.Path == "/branch",
    appBuilder => {
        // logging
        appBuilder.Use(async (context, next) =>
        {
            Console.WriteLine($"{DateTime.Now.ToShortTimeString()}: /branch");
            await next();
        });
        appBuilder.Run(async context =>
        {
            await context.Response.WriteAsync("Branch");
        });
    }
);
app.Use(GetDate);
app.Use(GetTime);
app.Run(GetMainPage);

app.Run();
