namespace SirvIces.middleware
{
    public class ServiceMiddleware
    {
        private readonly IServiceCollection services;
        private readonly RequestDelegate next;
        public ServiceMiddleware(RequestDelegate next, IServiceCollection services)
        {
            this.next = next;
            this.services = services;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Path.Equals("/services"))
            {
                string output = string.Empty;
                foreach (var service in services)
                {
                    output = $"<p>{output}{service.ServiceType?.FullName} - {service.Lifetime}</p>";
                }
                await context.Response.WriteAsync(output);
            }
            else
            {
                await next.Invoke(context);
            }
        }
    }
}
