using Microsoft.AspNetCore.Mvc;
using RoomManagerMvcApp.Data;
using RoomManagerMvcApp.DTO;

namespace RoomManagerMvcApp.Controllers
{
    public class AddRoomController : Controller
        
    {
        RoomManagerDbContext context;
        public AddRoomController(RoomManagerDbContext ctx) {
            context = ctx;
        }
        [HttpGet]
        public IActionResult Add()
        {
            MeetingRoomDTO model = new MeetingRoomDTO();
            
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(MeetingRoom model)
        {
            MeetingRoom m = new MeetingRoom()
            {
                RoomId = Guid.NewGuid(),
                RoomName = model.RoomName,
                Capacity = model.Capacity,
                Location = model.Location,
            };
            context.MeetingRoomSet.Add(m);
            context.SaveChanges();
            return View(model);
        }
    }
}
