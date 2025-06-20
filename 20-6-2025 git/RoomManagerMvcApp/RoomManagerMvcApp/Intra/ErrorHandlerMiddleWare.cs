
using Microsoft.AspNetCore.Mvc;

namespace RoomManagerMvcApp.Intra
{
    public class ErrorHandlerMiddleWare : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {

            try
            {
                await next(context);

            }
            catch (Exception ex)
            {
                context.Response.Redirect("/Error/PipeError");
            }

        }
    }
}
