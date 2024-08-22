using Microsoft.AspNetCore.Mvc;

namespace myPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.v = "~/hola-master/images/hero-bg.jpg";
            return View();
        }
    }
}
