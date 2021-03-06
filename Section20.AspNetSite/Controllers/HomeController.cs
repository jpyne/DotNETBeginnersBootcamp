﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Section20.AspNetSite.Models;

namespace Section20.AspNetSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Random random = new Random();
            
            HttpContext.Session.SetString("UserId", random.Next(99999).ToString());
            ViewData["UserEmail"] = "<a href='mailto:me@mail.com'>me@mail.com</a>";
            ViewBag.UserName = "<h1>Main User</h1>";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = $"Your user Id is: {HttpContext.Session.GetString("UserId")}";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
