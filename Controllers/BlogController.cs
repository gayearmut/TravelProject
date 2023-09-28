using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;
using TravelProject.Models.Classes;

namespace TravelProject.Controllers
{
	public class BlogController : Controller
	{
		Context context= new Context();
		BlogYorum by = new BlogYorum();
		public IActionResult Index()
		{
			//var blogs = context.Blogs.ToList();
			by.Deger1 = context.Blogs.ToList();
			by.Deger3 = context.Blogs.OrderByDescending(x => x.ID).Take(5).ToList();
			return View(by);
		}

		
		public ActionResult BlogDetay(int id) 
		{
			//var blogBul = context.Blogs.Where(x=>x.ID == id).ToList();
			by.Deger1=context.Blogs.Where(x => x.ID == id).ToList();
			by.Deger2=context.Comments.Where(x => x.Blogid == id).ToList();

			return View(by);
		}

		[HttpGet]
		public PartialViewResult YorumYap(int id)
		{
			ViewBag.deger = id;
			//ViewData["id"] = id;
			return PartialView();
		}

		[HttpPost]
		public PartialViewResult YorumYap(Comment comment)
		{
			context.Comments.Add(comment);
			context.SaveChanges();
			return PartialView();
		}
	}
}
