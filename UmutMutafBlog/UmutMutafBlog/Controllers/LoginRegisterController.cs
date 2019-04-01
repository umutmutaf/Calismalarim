using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UmutMutafBlog.Classes;
using UmutMutafBlog.Entities;

namespace UmutMutafBlog.Controllers
{
    public class LoginRegisterController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user, string rememberMe)
        {
            var userEntity = DbFactory.UserCrud.Records.FirstOrDefault(x => x.KullanıcıAdı == user.KullanıcıAdı && x.Sifre == user.Sifre);
            if (userEntity != null)//kullanıcı var demek
            {
                var encryptedId = OhmCryptor.OhmCryptor.Encrypt(userEntity.ID, UserFactory.SuperSecretKey);
                HttpCookie cookie = new HttpCookie("userId", encryptedId);
                if (rememberMe == null)
                {
                    //seçili değil
                    cookie.Expires = DateTime.Now.AddDays(1);
                }
                else
                {
                    //seçili
                    cookie.Expires = DateTime.Now.AddDays(30);
                }
                Response.Cookies.Add(cookie);
                return RedirectToAction("Index", "Home", null);
            }
            else//kullanıcı bulunamadı
            {
                TempData["errorMessage"] = "Kullanıcı adı ve/veya şifre hatalı";
                return View();
            }
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            DbFactory.UserCrud.Insert(user);
            return RedirectToAction("Login");
        }
    }
}