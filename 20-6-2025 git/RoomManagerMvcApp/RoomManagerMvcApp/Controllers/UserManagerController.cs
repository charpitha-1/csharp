using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RoomManagerMvcApp.Data;
using RoomManagerMvcApp.DTO;
using System.Linq;

namespace RoomManagerMvcApp.Controllers
{
    [Authorize]
    public class UserManagerController : Controller
    {
        private RoomManagerDbContext context;
        public UserManagerController(RoomManagerDbContext ctx) 
        {
            context = ctx;
        }  
        [HttpGet]
        public IActionResult UserView()
        {
            //model list of userinfodto details 
            List<UserInfoDTO> Result=(context.UserInfoSet.Select(u => new UserInfoDTO()
            {
                DiaplayName=u.DiaplayName,
                Email=u.Email,
                UserRole=u.UserRole,
                UserId=u.UserId,  
            })).ToList();    
            return View(Result);
        }
        [HttpGet]
        [Authorize(Policy ="OnlyAdmin")]
        public IActionResult AddUser()
        {
            UserAddInfoDTO model= new UserAddInfoDTO();
            return View(model);
        }
        [HttpPost]
        public IActionResult AddUSer(UserAddInfoDTO model)
        {
            if(ModelState.IsValid)
            {
                UserInfo newobj = new UserInfo()
                {
                    DiaplayName=model.DiaplayName,
                    Email=model.Email,
                    UserId=Guid.NewGuid(),
                    Password=model.Password,
                    UserRole=model.UserRole
                };
                context.UserInfoSet.Add(newobj);
                int Rows=context.SaveChanges();
                if(Rows>0)
                {
                    return RedirectToAction("UserView");
                }
            }
            return View(model);
        }
    }
}
