using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OtelRezervasyon.Entity.Concrete;
using OtelRezervasyon.webui.Dtos.LoginDto;

namespace OtelRezervasyon.webui.Controllers
{
    
    public class LoginController : Controller
    {

        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginUserDto loginUserDto)
        {
            if(ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginUserDto.Username, loginUserDto.Password, false, false);
                if(result.Succeeded)
                {
                    Console.WriteLine("1");
                    return RedirectToAction("Index","Staff");
                }
                else
                {
                    return View();
                }

            }
            return View();
        }

    }
}