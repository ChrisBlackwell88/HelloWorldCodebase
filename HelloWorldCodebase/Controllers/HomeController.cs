﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldCodebase.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // New code changes here
            // try Visual studio checkin
            // yes visual studio works!!!
            // test 123 GO!
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}