using bajki.Models;
using Microsoft.AspNetCore.Mvc;

namespace bajki.Controllers
{
	public class AdminController : Controller
	{
		private readonly MyDbContext _db;
		List<Tale> TaleList { get; set; }
		string url = "https://cdn.jsdelivr.net/npm/@tabler/icons-webfont@latest/tabler-icons.min.css";

		public AdminController(MyDbContext db)
		{
			_db = db;
			TaleList = _db.Tales.OrderBy(tale => tale.OrderID).ToList();
		}




		[Route("/admin")]
		public IActionResult Admin(User? user)
		{
			//         User? user1=new User();
			//         if (user.Login!= null)
			//         {
			//	user1 = _db.Users.FirstOrDefault(userx => user != null && userx.Login.ToLower() == user.Login.ToLower());
			//}

			//         if(user1!= null && user.Login !=null && user1.Password==user.Password) {


			//	ViewBag.TaleList = _db.Tales.OrderByDescending(tale => tale.OrderID).ToList();

			//	return View();


			//}
			//         else
			//         {
			//	ViewBag.url = url;
			//	return View("AdminLogin");
			//}
			ViewBag.TaleList = _db.Tales.OrderBy(tale => tale.OrderID).ToList();
			ViewBag.Url = url;
			return View();

		}

		[Route("/admin/dodaj")]
		public IActionResult Add(Tale? Tale)
		{
			return View();
		}


		[Route("/admin/usun")]
		public IActionResult Delete(Tale? Tale)
		{
			return View();
		}

		[Route("/admin/edytuj/{id:int}")]
		public IActionResult Edit(Tale? Tale)
		{
			return View();
		}


	}
}
