using Microsoft.AspNetCore.Mvc;
using TravelProject.Models.Classes;

namespace TravelProject.Controllers
{
    public class AboutController : Controller
    {
        Context context = new Context();
        public IActionResult About()
        {
            var degerler =context.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}
