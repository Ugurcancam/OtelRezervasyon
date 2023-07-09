using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OtelRezervasyon.Entity.Concrete;
using OtelRezervasyon.webui.Dtos.RegisterDto;

namespace OtelRezervasyon.webui.Controllers
{
    
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(NewUserDto newUserDto)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            var appUser = new AppUser(){
                AdSoyad = newUserDto.AdSoyad,
                Email  = newUserDto.Mail,
                UserName = newUserDto.Username
            };

            var result = await _userManager.CreateAsync(appUser, newUserDto.Password);
            
            if(result.Succeeded)
            {
                return RedirectToAction("Index","Login");
            }
            return View();
        }

    }
}