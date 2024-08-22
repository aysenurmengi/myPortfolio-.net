using Microsoft.AspNetCore.Mvc;
using myPortfolio.DAL.Context;

namespace myPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();  
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count(); //yetenek sayım
            ViewBag.v2 = context.Messages.Count(); //toplam mesaj sayısı
            ViewBag.v3 = context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.v4 = context.Messages.Where(x => x.IsRead == true).Count();

            return View();
        }
    }
}
