using SirvIces.services.math;

namespace SirvIces.middleware
{
    public class FunctionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly FunctionResult _result;
        public FunctionMiddleware(RequestDelegate next, FunctionResult result)
        {
            _next = next;
            _result = result;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Path.Equals("/func"))
            {
                await context.Response.WriteAsync($"<p>f(x)={_result.GetResult(20)}</p>");
            }
            else
            {
                await _next(context);
            }
        }
    }
}
