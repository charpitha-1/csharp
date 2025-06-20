using Microsoft.AspNetCore.Mvc;

namespace RoomManagerMvcApp.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult PipeError()
        {
            return View();
        }
    }
}
