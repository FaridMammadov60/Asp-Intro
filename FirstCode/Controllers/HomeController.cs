using Microsoft.AspNetCore.Mvc;

namespace FirstCode.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            //return Content($"isledi {id}");
            return View();
        }
        public IActionResult About()
        {
            //return Content("about isledi");
            return View();
        }
    }
}
