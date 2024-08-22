using Microsoft.AspNetCore.Mvc;

namespace myPortfolio.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
        return View(); 
        }
    }
}
