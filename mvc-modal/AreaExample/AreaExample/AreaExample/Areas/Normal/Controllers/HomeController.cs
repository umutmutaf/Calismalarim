﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AreaExample.Areas.Normal.Controllers
{
    public class HomeController : Controller
    {
        // GET: Normal/Home
        [CustomAuthorize(isAdmin:false)]
        public ActionResult Index()
        {
            return View();
        }
    }
}