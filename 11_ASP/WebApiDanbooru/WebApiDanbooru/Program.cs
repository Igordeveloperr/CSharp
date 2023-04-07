using System.Text;
using WebApiDanbooru;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
string html = "";
async Task ExecuteQuery()
{
    var booru = new BooruSharp.Booru.DanbooruDonmai();
    var response = await booru.GetRandomPostsAsync(10,"sex");
    foreach(var post in response)
    {
        if (post.FileUrl != null)
        {
            html = $"{html}<img width='600' height='600' alt='aaaa' src='{post.FileUrl.AbsoluteUri}'/>\n";
        }
    }
    Console.WriteLine(html);
}

 
app.Run(async context =>
{
    await ExecuteQuery();
    context.Response.ContentType = "text/html; charset=utf-8";
    await context.Response.WriteAsync(html);
    html = "";
});

app.Run();
