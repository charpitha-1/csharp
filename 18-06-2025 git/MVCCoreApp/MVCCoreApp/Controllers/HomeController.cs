using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCCoreApp.Models;
using System.IO;
using MVCCoreApp.Infra;

namespace MVCCoreApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        BService _srv;
        IConfiguration _config;

        public HomeController(ILogger<HomeController> logger,BService srv,IConfiguration config)
        {
            _logger = logger;
            _srv = srv;
            _config = config;
        }
        public IActionResult Index()
        {
            string secret = _config.GetValue<string>("AppKey:Secret");
            ViewBag.Msg = secret;
            return View();
        }



        /*public IActionResult Index()
        {
            var res = _srv.GetMessage();
            ViewBag.Message=res;

            return View();
        }*/

        /*public IActionResult Index()
        {
            FileStream fs = new FileStream("Sample.txt",FileMode.Open,FileAccess.Read);
            byte[] filecontent=new byte[fs.Length];
            fs.Read(filecontent, 0, filecontent.Length);
            fs.Close();
            return new FileContentResult(filecontent,"application/text");
            //return View();
        }
        */
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
