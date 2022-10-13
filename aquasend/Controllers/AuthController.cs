using aquasend.Models;
using aquasend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aquasend.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([FromForm] LoginModel model)
        {
            var (error, user) = await _userService.Login(model.Email, model.Password);
            if (user == null)
            {
                TempData["ErrorMsg"] = error;
                return RedirectToAction("Login", "Auth");
            }
            else
            {
                HttpContext.Session.SetString("JWToken", error);
                if (user.IsAdmin)
                {
                    return RedirectToAction("Dashboard", "Admins");
                }

                return RedirectToAction("Dashboard", "Users");
            }

        }



        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([FromForm] RegisterModel model)
        {
            var (isRegistered, error) = await _userService.Register(model);
            if (isRegistered != true)
                return BadRequest(new { message = "could not register" });
            TempData["Success"] = "Registration successful, please login.";
            return RedirectToAction("Login");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
