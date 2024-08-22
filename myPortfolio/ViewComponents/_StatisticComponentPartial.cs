using Microsoft.AspNetCore.Mvc;

namespace myPortfolio.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {  
            return View(); 
        }
    }
}
