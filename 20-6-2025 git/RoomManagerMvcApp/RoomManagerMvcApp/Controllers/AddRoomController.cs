using Microsoft.AspNetCore.Mvc;
using RoomManagerMvcApp.Data;
using RoomManagerMvcApp.DTO;

namespace RoomManagerMvcApp.Controllers
{
    public class AddRoomController : Controller
        
    {
        ILogger<AddRoomController> _logger;
        RoomManagerDbContext context;
        public AddRoomController(RoomManagerDbContext ctx,ILogger<AddRoomController> logger) {
            context = ctx;
            _logger= logger;
        }
        [HttpGet]
        public IActionResult ReserveRoom()
        {
            return View();
        }
        [HttpGet]
        public IActionResult  ViewRooms()
        {
            MeetingRoomViewDTO model =  new MeetingRoomViewDTO();
            List<MeetingRoom> Mrooms = context.MeetingRoomSet.ToList();
            _logger.LogInformation("Data Fetched");
            foreach (MeetingRoom room in Mrooms)
            {
                RoomEntry roomEntry = new RoomEntry()
                {
                    RoomId = room.RoomId,
                    RoomName = room.RoomName,
                    Capacity = room.Capacity,
                    Location = room.Location,
                };
                model.rooms.Add(roomEntry);
            }
            return View(model);
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
            MeetingRoom rooms = new MeetingRoom()
            {
                RoomId = Guid.NewGuid(),
                RoomName = model.RoomName,
                Capacity = model.Capacity,
                Location = model.Location,
            };
            context.MeetingRoomSet.Add(rooms);
            context.SaveChanges();

            return View(model);
        }
    }
}
