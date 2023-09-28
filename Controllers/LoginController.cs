using Microsoft.AspNetCore.Mvc;
using TravelProject.Models.Classes;


namespace TravelProject.Controllers
{
	public class LoginController : Controller
	{
		private readonly Context _context;

		public LoginController(Context context)
		{
			_context = context;
		}

		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Login(Admin ad)
		{
			var admin = _context.Admins.FirstOrDefault(x => x.Kullanici == ad.Kullanici && x.Sifre == ad.Sifre);

			if (admin != null)
			{
				return RedirectToAction("Index", "Admin");
			}
			else
			{
				ViewBag.ErrorMessage = "Kullanıcı adı veya şifre hatalı.";
				return View();
			}
		}
	}
}
