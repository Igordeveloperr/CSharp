
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

//app.UseWelcomePage(); // подключение встроеного компонента middleware

app.Run();
