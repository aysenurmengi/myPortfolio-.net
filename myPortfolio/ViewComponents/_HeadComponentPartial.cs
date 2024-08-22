using Microsoft.AspNetCore.Mvc;

namespace myPortfolio.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent //viewcomponent olduğunu belirttik, miras aldık
    {
        public IViewComponentResult Invoke() //controllerdaki IActionResult gibi
        {
            return View();
        }
    }
}
