using SirvIces.services.time;

namespace SirvIces.middleware
{
    public class DefaultMiddleware
    {
        private readonly RequestDelegate _next;
        public DefaultMiddleware(RequestDelegate next)
        {
            this._next = next;
        }
        public async Task InvokeAsync(HttpContext context, ITimeService time)
        {
            string res = time.GetTime();
            await context.Response.WriteAsync(res);
        }
    }
}
