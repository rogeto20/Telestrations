﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2.Controllers
{
    public class SetupController : Controller
    {
        // GET: Setup
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Preview()
        {
            return View();
        }
    }
}