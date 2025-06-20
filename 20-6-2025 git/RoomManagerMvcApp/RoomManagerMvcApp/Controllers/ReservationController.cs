using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RoomManagerMvcApp.Controllers
{
   
    public class ReservationController : Controller
    {
       
        [HttpGet]
        public IActionResult Reserve()
        {
            return View();
        }
    }
}
