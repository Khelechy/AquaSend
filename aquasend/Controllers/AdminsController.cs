using aquasend.Models;
using aquasend.Services;
using aquasend.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aquasend.Controllers
{
    public class AdminsController : Controller
    {
        private readonly IRequestService _requestService;
        private readonly IUserService _userService;

        public AdminsController(IRequestService requestService, IUserService userService)
        {
            _requestService = requestService;
            _userService = userService;
        }
        public async Task<IActionResult> Dashboard()
        {
            var token = HttpContext.Session.GetString("JWToken");
            if (string.IsNullOrEmpty(token))
            {
                return RedirectToAction("Login", "Auth");
            }
            var statistics = await _userService.LoadStatistics();
            var user = await _userService.GetUser();
            var response = new AdminDashboardViewModel
            {
                User = user,
                StatisticsData = statistics
            };
            return View(response);
        }

        public async Task<IActionResult> Users(string searchString = "")
        {
            var token = HttpContext.Session.GetString("JWToken");
            if (string.IsNullOrEmpty(token))
            {
                return RedirectToAction("Login", "Auth");
            }
            var users = await _userService.GetAllUsers(searchString);
            return View(users);
        }

        public async Task<IActionResult> Drivers(string searchString = "")
        {
            var users = await _userService.GetAllDrivers(searchString);
            return View(users);
        }

        public async Task<IActionResult> Requests()
        {
            var token = HttpContext.Session.GetString("JWToken");
            if (string.IsNullOrEmpty(token))
            {
                return RedirectToAction("Login", "Auth");
            }
            await PopulateDriversDropDownList();
            var requests = await _requestService.GetAllRequest();
            return View(requests);
        }

        public async Task<IActionResult> AcceptRequest(int id, string driverId){
           var isAccepted = await _requestService.AcceptRequest(id, driverId);
            if (isAccepted)
            {
                ViewBag.Message = "Request has been accepted";
                return RedirectToAction("Requests", "Admins");
            }
            else
            {
                ViewBag.Error = "Sorry there was an error encountered on accepting this request";
                return RedirectToAction("Requests", "Admins");
            }
        }

        public async Task<IActionResult> RejectRequest(int id)
        {
            var isAccepted = await _requestService.RejectRequest(id);
            if (isAccepted)
            {
                ViewBag.Message = "Request has been rejected";
                return RedirectToAction("Requests", "Admins");
            }
            else
            {
                ViewBag.Error = "Sorry there was an error encountered on rejecting this request";
                return RedirectToAction("Requests", "Admins");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddDriver([FromForm] RegisterModel model)
        {
            var (isRegistered, error) = await _userService.AddDriver(model);
            if (isRegistered != true)
            {
                TempData["Error"] = error;
                return RedirectToAction("Drivers", "Admins");
            }
            else
            {
                TempData["Success"] = "Driver has been registered successfully.";
                return RedirectToAction("Drivers", "Admins");
            }
                
        }

        [HttpGet]
        public async Task<IActionResult> DeleteUser(string id)
        {
            await _userService.DeleteUser(id);
            return RedirectToAction("Drivers", "Admins");
        }

        private async Task PopulateDriversDropDownList(object selectedDriver = null)
        {
            var drivers = await _userService.GetAllDrivers();
            ViewBag.DriverId = new SelectList(drivers, "Id", "Email", selectedDriver);
        }
    }
}
