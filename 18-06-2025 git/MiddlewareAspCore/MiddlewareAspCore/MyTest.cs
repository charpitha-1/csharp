namespace MiddlewareAspCore
{
    public class MyTest
    {
        private RequestDelegate _next;
        public MyTest(RequestDelegate next) 
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext ctx)
        {
            await ctx.Response.WriteAsync("Inside mvc before class ----");
            //await ctx.Response.WriteAsJsonAsync("My test middle");
            await _next.Invoke(ctx);
            await ctx.Response.WriteAsync("Inside mvc after class----");
        }
    }
}
