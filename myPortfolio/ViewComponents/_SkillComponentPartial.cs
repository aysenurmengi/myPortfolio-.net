﻿using Microsoft.AspNetCore.Mvc;
using myPortfolio.DAL.Context;

namespace myPortfolio.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Skills.ToList();
             return View(values); 
        }
    }
}
