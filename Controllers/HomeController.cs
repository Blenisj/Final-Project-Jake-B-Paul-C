﻿using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Final_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> log;

        public HomeController(ILogger<HomeController> logger)
        {
            log = logger;
        }

        public IActionResult Index()
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
    }
}