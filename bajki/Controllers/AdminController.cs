using bajki.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

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

			ViewBag.TaleList = TaleList;
			ViewBag.Url = url;
			return View();

		}

		[Route("/admin/zapisz")]
		public IActionResult Save(List<int> intList)
		{
			if (intList != null)
			{
				for (int i = 0; i < TaleList.Count; i++)
				{
					TaleList[i].OrderID = intList[i];
					_db.Tales.Update(TaleList[i]);

				}
				_db.SaveChanges();

				ViewBag.TaleList = TaleList.OrderBy(ty => ty.OrderID).ToList();
				ViewBag.Url = url;
				return View("Admin");
			}
			else
			{
				//tu obsluga błedu
				return View("Admin");
			}
		}

		[Route("/admin/dodaj")]
		public IActionResult Add(Tale? tale)
		{
			ViewBag.TaleList = TaleList;
			ViewBag.Url = url;

			return View();
		}
		[Route("/admin/dodano")]
		public IActionResult Added(Tale? tale)
		{
			ViewBag.TaleList = TaleList;
			ViewBag.Url = url;
			if (tale.Title != null)
			{
				Tale tmp = new Tale();
				tmp = tale;
				tmp.CreateTime = DateTime.Now;
				tmp.OrderID = 0;
				tmp.Description = "";
				int maxId = 0;
				foreach (Tale t in TaleList)
				{
					t.OrderID += 1;
					if (t.Id > maxId)
					{
						maxId = t.Id;
					}
					_db.Tales.Update(t);

				}
				tmp.Id = 0;
				_db.Tales.Add(tmp);
				_db.SaveChanges();
				return View("Added");
			}



			return View("Add");
		}


		[Route("/admin/edytuj/{id:int}")]
		public IActionResult Edit(int id, Tale? editedTale)
		{
			ViewBag.TaleList = TaleList;
			ViewBag.Url = url;
			Tale tale = new Tale();
			Tale taleToEdit = new Tale();
			if (id == 0)
			{
				return View("Add");
			}
			else
			{

				taleToEdit = _db.Tales.Find(id);
				if (taleToEdit == null)
				{
					return View("Add");
				}


				if (taleToEdit.Paragraph2 == null)
				{
					taleToEdit.Paragraph2 = "";
				}
				else if (taleToEdit.Paragraph3 == null)
				{
					taleToEdit.Paragraph3 = "";
				}
				else if (taleToEdit.Paragraph4 == null)
				{
					taleToEdit.Paragraph4 = "";
				}
				else if (taleToEdit.Paragraph5 == null)
				{
					taleToEdit.Paragraph5 = "";
				}
				else if (taleToEdit.Paragraph6 == null)
				{
					taleToEdit.Paragraph6 = "";
				}
				else if (taleToEdit.Paragraph7 == null)
				{
					taleToEdit.Paragraph7 = "";
				}
				else if (taleToEdit.Paragraph8 == null)
				{
					taleToEdit.Paragraph8 = "";
				}
				else if (taleToEdit.Paragraph9 == null)
				{
					taleToEdit.Paragraph9 = "";
				}

				ViewBag.TaleToEdit = taleToEdit;
				return View();
			}

		}


		[Route("/admin/edytuj/sukces/{id:int}")]
		public IActionResult Edited(int id, Tale? editedTale)
		{
			ViewBag.TaleList = TaleList;
			ViewBag.Url = url;
            ViewBag.TaleToEdit = editedTale;
			if(editedTale != null)
			{
				Tale tmp = _db.Tales.Find(id);
				tmp.Title=editedTale.Title;
				tmp.Picture=editedTale.Picture;
				tmp.Description=editedTale.Description;
				tmp.Miniature=editedTale.Miniature;
				tmp.Paragraph1 = editedTale.Paragraph1;
				tmp.Paragraph2 = editedTale.Paragraph2;
				tmp.Paragraph3 = editedTale.Paragraph3;
				tmp.Paragraph4= editedTale.Paragraph4;
				tmp.Paragraph5= editedTale.Paragraph5;
				tmp.Paragraph6 = editedTale.Paragraph6;
				tmp.Paragraph7= editedTale.Paragraph7;
				tmp.Paragraph8 = editedTale.Paragraph8;
				tmp.Paragraph9 = editedTale.Paragraph9;
                _db.Tales.Update(tmp);
                _db.SaveChanges();
            }

            return View("Edit");

		}

		[Route("/admin/usun/{id:int}")]
		public IActionResult Delete(Tale? Tale)
		{
			return View();
		}
	}
}
