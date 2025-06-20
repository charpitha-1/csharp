using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using RoomManagerMvcApp.Data;
using RoomManagerMvcApp.DTO;
using System.Security.Claims;
using System.Text.Json;

namespace RoomManagerMvcApp.Controllers
{
    public class AccountController : Controller
    {
        private RoomManagerDbContext ctx;
        public AccountController(RoomManagerDbContext con) {
            ctx = con;

        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginInfoDTO model)
        {
            if(ModelState.IsValid)
            {
                UserInfo ui=ctx.UserInfoSet.Where(u=>u.Email == model.Email&& u.Password==model.Password).FirstOrDefault();
                if (ui != null) //login succes
                {
                    //step1 ---to which to check the email and role have access or not
                    List<Claim> claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.Name,ui.Email));
                    claims.Add(new Claim(ClaimTypes.Role,ui.UserRole));
                    //step-2 checking with cookie that is cache
                    ClaimsIdentity claimsIdentity = new ClaimsIdentity
                        (claims,CookieAuthenticationDefaults.AuthenticationScheme);
                    //step-3 ---giving access to the pages
                    ClaimsPrincipal principle=new ClaimsPrincipal(claimsIdentity);
                    await HttpContext.SignInAsync(principle);
                    string sUserInfo=JsonSerializer.Serialize(ui); 
                    //Json will convert the object to string
                    HttpContext.Session.SetString("UserInfo",sUserInfo);
                    return RedirectToAction("UserView","UserManager");
                }
            }
            return View();
        }
    }
}
