using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OtelRezervasyon.webui.ViewComponents.About
{
    public class AboutViewComponent : ViewComponent
    
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}