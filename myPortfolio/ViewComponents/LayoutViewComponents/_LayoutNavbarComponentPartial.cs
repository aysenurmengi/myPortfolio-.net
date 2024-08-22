using Microsoft.AspNetCore.Mvc;
using myPortfolio.DAL.Context;

namespace myPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount = context.ToDoLists.Where(x => x.Status == false).Count(); // yapılmamış bildirim sayısı
            var values = context.ToDoLists.Where(x => x.Status == false).ToList(); // yapılmamış bildirim listesi

            return View(values); 
        }
    }
}
