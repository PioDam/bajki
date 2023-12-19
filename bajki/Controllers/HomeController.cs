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

        public List<string> myReplace(string str)
        {
            if (str == null) return null;
            List <string> tmp=str.Split("\r\n").ToList();
            return tmp;

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
            ViewBag.Paragraph1 = myReplace(tale.Paragraph1);
            ViewBag.Paragraph2 = myReplace(tale.Paragraph2);
            ViewBag.Paragraph3 = myReplace(tale.Paragraph3);
            ViewBag.Paragraph4 = myReplace(tale.Paragraph4);
            ViewBag.Paragraph5 = myReplace(tale.Paragraph5);
            ViewBag.Paragraph6 = myReplace(tale.Paragraph6);
            ViewBag.Paragraph7 = myReplace(tale.Paragraph7);
            ViewBag.Paragraph8 = myReplace(tale.Paragraph8);
            ViewBag.Paragraph9 = myReplace(tale.Paragraph9);

            ViewBag.Tale = tale;
			ViewBag.url = url;
			return View();
        }


	}
}
