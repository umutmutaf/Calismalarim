using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class SubeController : Controller
    {
        // GET: Sube
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SubeOlustur()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SubeOlustur(Sube sube)
        {
            return View();
        }
    }
}