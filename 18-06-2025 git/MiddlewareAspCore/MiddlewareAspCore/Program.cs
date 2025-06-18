using MiddlewareAspCore;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.Use(async (ctx, nxt) =>
    {
        await ctx.Response.WriteAsync("Inside mvc before----");
        await nxt.Invoke();
        await ctx.Response.WriteAsync("Outside mvc after----");
    });
app.Use(async (ctx, nxt) =>
{
    await ctx.Response.WriteAsync("Inside mvc1 before----");
    await nxt.Invoke();
    await ctx.Response.WriteAsync("Outside mvc1 after----");
});
app.UseMiddleware<MyTest>(); //use middleware is a class
app.Run();
