using Microsoft.AspNetCore.Mvc;

namespace myPortfolio.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
