﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula1.Controllers
{
    public class HomeController : Controller
    {
            //
            // GET: /Home/
            public ActionResult Index()
            {
                return View();
            }
    }
}