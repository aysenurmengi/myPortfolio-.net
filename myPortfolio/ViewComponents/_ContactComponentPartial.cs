﻿using Microsoft.AspNetCore.Mvc;

namespace myPortfolio.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
