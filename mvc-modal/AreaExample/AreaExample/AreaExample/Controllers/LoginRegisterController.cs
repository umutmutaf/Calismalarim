using AreaExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AreaExample.Areas.Normal.Controllers
{
    public class LoginRegisterController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user, string rememberMe)
        {
            var encryptedId = OhmCryptor.OhmCryptor.Encrypt(user.Id, UserFactory.SuperSecretKey);
            HttpCookie cookie = new HttpCookie("userId", encryptedId);
            if (rememberMe == null)
            {
                //seçili değil
                cookie.Expires = DateTime.Now.AddHours(1);
            }
            else
            {
                //seçili
                cookie.Expires = DateTime.Now.AddDays(30);
            }
            Response.Cookies.Add(cookie);
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            return View();
        }
    }
}