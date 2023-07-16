using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OtelRezervasyon.webui.ViewComponents.Testimonial
{
    public class TestimonialViewComponent : ViewComponent
    
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}