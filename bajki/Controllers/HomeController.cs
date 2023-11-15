using Microsoft.AspNetCore.Mvc;

namespace bajki.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }


        [Route("/admin")]
        public IActionResult AdminLogin()
        {
            return View();
        }
    }
}
