using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OtelRezervasyon.webui.Models;

namespace OtelRezervasyon.webui.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

}
