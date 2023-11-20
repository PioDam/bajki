using bajki.Models;
using bajki.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bajki.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDbContext _db;
        List <Tale> TaleList { get; set; }
        readonly string url = "https://cdn.jsdelivr.net/npm/@tabler/icons-webfont@latest/tabler-icons.min.css";

		public HomeController(MyDbContext db)
        {
            _db = db;
			TaleList = _db.Tales.OrderBy(tale => tale.OrderID).ToList();
		}



        [Route("/")]
        public IActionResult Index()
        {
            ViewBag.TaleList = TaleList;
            string? title1 = TaleList[0].Title;
            ViewBag.Title = title1;
            return View();
        }

		[Route("/login")]
		public IActionResult AdminLogin()
		{
            ViewBag.url = url;
			
			return View();
		}


		[Route("/{id:int}")]
        public IActionResult Tale(int id)
        {
            Tale? tale = _db.Tales.Find(id);
            if(tale!=null)
            {

                Tale? nextTale=_db.Tales.FirstOrDefault(talex => talex.OrderID==(tale.OrderID+1) );
                ViewBag.nextTale=nextTale;
                ViewBag.taleList = TaleList;
            }
            else
            {
                //trzeba zrobić strone błędu, jak ktoś wpisze złe id

            }
            ViewBag.Tale = tale;
			ViewBag.url = url;
			return View();
        }


	}
}
