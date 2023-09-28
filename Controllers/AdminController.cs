using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelProject.Models.Classes;

namespace TravelProject.Controllers
{
    //[Authorize]
    public class AdminController : Controller
	{
		Context context = new Context();

		
		public IActionResult Index()
		{
			var degerler = context.Blogs.ToList();
			return View(degerler);
		}
        [HttpGet]
        public IActionResult YeniBlog()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult YeniBlog(Blog p)
        {
            context.Blogs.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var blog = context.Blogs.Find(id);
            context.Blogs.Remove(blog);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult BlogGetir(int id)
        {
            var blog = context.Blogs.Find(id);
            return View("BlogGetir",blog);
        }
        
        public ActionResult BlogGuncelle(Blog blog)
        {
            var blg = context.Blogs.Find(blog.ID);
            blg.Aciklama = blog.Aciklama;
            blg.Baslik = blog.Baslik;
            blg.BlogImage = blog.BlogImage;
            blg.Tarih = blog.Tarih;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var yorumlar =context.Comments.ToList();
            return View(yorumlar);
        }

        public ActionResult YorumSil(int id)
        {
            var y = context.Comments.Find(id);
            context.Comments.Remove(y);
            context.SaveChanges();
            return RedirectToAction("YorumListesi");

        }

        public ActionResult YorumGetir(int id)
        {
            var yr = context.Comments.Find(id);
            return View("YorumGetir", yr);
        }

        public ActionResult YorumGuncelle(Comment y)
        {
            var yrm = context.Comments.Find(y.ID);
            yrm.KullaniciAdi = y.KullaniciAdi;
            yrm.Email = y.Email;
            yrm.Yorum = y.Yorum;
            context.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}
