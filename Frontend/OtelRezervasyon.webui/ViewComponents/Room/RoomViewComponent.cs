using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OtelRezervasyon.webui.ViewComponents.Room
{
    public class RoomViewComponent : ViewComponent
    
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}