
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace RoomManagerMvcApp.Intra
{
    public class MyExceptionFilter : IExceptionFilter

    {
        public void OnException(ExceptionContext context)
        {
            context.Result = new RedirectToActionResult("Index", "Error", null);
        }
    }
}
