using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AreaExample.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        [CustomAuthorize(isAdmin:true)]
        public ActionResult Index()
        {
            return View();
        }
    }
}