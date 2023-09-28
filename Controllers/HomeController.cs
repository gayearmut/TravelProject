using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TravelProject.Models;
using TravelProject.Models.Classes;

namespace TravelProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        Context context = new Context();   
        public IActionResult Index()
        {
            var degerler = context.Blogs.Take(3).ToList();
            return View(degerler);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public PartialViewResult Partial1()
        {
            var degerler = context.Blogs.OrderBy(x=>x.ID).ToList();
            return PartialView(degerler);
        }

		public PartialViewResult Partial2()
		{
            var degerler = context.Blogs.Take(5).ToList();
			return PartialView(degerler);
		}

        public PartialViewResult Partial3()
        {
            var degerler = context.Blogs.Take(3).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial4()
        {
            var degerler = context.Blogs.Take(3).OrderByDescending(x =>x.ID).ToList();
            return PartialView(degerler);
        }
    }
}