﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MSIT133Site.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MSIT133Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FirstAjax()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult AjaxPose()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AjaxPose(User user)
        {
            ViewBag.name = user.userName;
            return View();
        }

        public IActionResult AjaxFormdata()
        {
            return View();
        }

        public IActionResult Address()
        {
            return View();
        }
        public IActionResult History()
        {
            return View();
        }
        public IActionResult jQuery()
        {
            return View();
        }
        public IActionResult ShipperCors()
        {
            return View();
        }
        public IActionResult ShipperCorsEmpty()
        {
            return View();
        }
    }
}
