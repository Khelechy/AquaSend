using aquasend.Services;
using aquasend.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aquasend.Controllers
{
    public class UsersController : Controller
    {
        private readonly IRequestService _requestService;
        private readonly IUserService _userService;

        public UsersController(IRequestService requestService, IUserService userService)
        {
            _requestService = requestService;
            _userService = userService;
        }


        [HttpGet]
        public async Task<IActionResult> Dashboard()
        {
            var token = HttpContext.Session.GetString("JWToken");
            if(string.IsNullOrEmpty(token))
            {
                return RedirectToAction("Login", "Auth");
            }
            var user = await _userService.GetUser();
            return View(user);
        }


        [HttpGet]
        public async Task<IActionResult> Requests()
        {
            var token = HttpContext.Session.GetString("JWToken");
            if (string.IsNullOrEmpty(token))
            {
                return RedirectToAction("Login", "Auth");
            }
            var userId = _userService.GetUserId();
            var requests = await _requestService.GetUserRequest(userId);
            return View(requests);
        }

        [HttpPost]
        public async Task<IActionResult> MakeRequest([FromForm] RequestViewModel model)
        {
            var (response, error) = await _requestService.CreateRequest(model);
            if(response)
                TempData["Success"] = "Success";
            else
                TempData["Error"] = error;
            return RedirectToAction("Requests");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProfile([FromForm] UpdateProfileViewModel model)
        {
            var (result, msg, user) = await _userService.UpdateProfileAsync(model);
            if (result && user != null)
            {
                TempData["Success"] = msg;
                return RedirectToAction("Dashboard");
            }
            else
                TempData["Error"] = msg;
            return RedirectToAction("Dashboard");
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            var token = HttpContext.Session.GetString("JWToken");
            if (string.IsNullOrEmpty(token))
            {
                return RedirectToAction("Login", "Auth");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword([FromForm] ChangePasswordViewModel model)
        {
            var (response, msg) = await _userService.ChangePasswordAsync(model);
            if (response)
            {
                TempData["Success"] = msg;
                return View();
            }
            else
                TempData["Error"] = msg;
            return View();
        }
    }
}
