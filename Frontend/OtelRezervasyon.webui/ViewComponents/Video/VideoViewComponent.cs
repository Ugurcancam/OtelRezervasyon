using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OtelRezervasyon.webui.ViewComponents.Video
{
    public class VideoViewComponent : ViewComponent
    
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}