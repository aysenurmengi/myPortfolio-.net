using Microsoft.AspNetCore.Mvc;

namespace myPortfolio.ViewComponents
{
    public class _PortfolioComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
             return View();
        }
    }
}
