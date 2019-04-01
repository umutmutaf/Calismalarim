using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AreaExample.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult UnAuthorized401()
        {
            return View();
        }
        public ActionResult NotFound404()
        {
            return View();
        }
        public ActionResult Forbidden403()
        {
            return View();
        }
        public ActionResult InternalError500()
        {
            return View();
        }
    }
}