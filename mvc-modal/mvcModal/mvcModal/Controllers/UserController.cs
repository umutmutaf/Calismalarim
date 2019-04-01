using mvcModal.Classes;
using mvcModal.Models;
using OhmCryptor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcModal.Controllers
{
    public class UserController : Controller
    {
        static List<User> _users = new List<User>();
        // GET: User
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            var userEntity = _users.FirstOrDefault(x => x.Username == user.Username && x.Password == user.Password);
            if (userEntity==null)
            {
                TempData["loginMessage"] = "Kullanıcı adı şifre hatalı.";
            }
            else
            {
                //şifreleme
                var encryptedId = OhmCryptor.OhmCryptor.Encrypt(userEntity.Id, UserFactory.SuperSecretKey);
                HttpCookie httpCookie = new HttpCookie("userId", encryptedId);
                                                     //cookiename,cookievalue
                httpCookie.Expires = DateTime.Now.AddDays(7);
                Response.Cookies.Add(httpCookie);
                Session["currentUser"] = userEntity;
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        [CustomAuthorize]
        public ActionResult LogOut()
        {
            var cookie=Response.Cookies.Get("userId");
            cookie.Expires = DateTime.Now.AddDays(-1);//cookie yi otomatik olarak silmesi için geçmiş bir tarih veriyoruz
            Session["currentUser"] = null;
            return RedirectToAction("Index");
        }
        public ActionResult Index()
        {
            var user1 = new User();
            user1.Username = "umut";
            user1.Password = "123456";
            user1.Email = "u@u.com";
            user1.BirthDate = new DateTime(1991,07,29);

            var user2 = new User();
            user2.Username = "muhteşem";
            user2.Password = "123456";
            user2.Email = "m@m.com";
            user2.BirthDate = new DateTime(1986, 02, 07);

            var user3 = new User();
            user3.Username = "edip";
            user3.Password = "123456";
            user3.Email = "e@e.com";
            user3.BirthDate = new DateTime(2021, 07, 29);

            _users.Add(user1);
            _users.Add(user2);
            _users.Add(user3);

            for (int i = 0; i < 100; i++)
            {
                _users.Add(new Models.User { Username = "mutmut", Password = "123456", BirthDate = new DateTime(1991, 07, 29), Email = i + "u@u" });
            }

            //var cookie = Request.Cookies.Get("userId");
            //if (cookie==null)
            //{
            //    return RedirectToAction("Login");
            //}
            //string id = cookie.Value;
            //User currentUser = _users.FirstOrDefault(x => x.Id == id);
            //if (currentUser==null)
            //{
            //    //eğer id yoksa veya değiştirilmiş ise login e geri döndürülür
            //    return RedirectToAction("Login");
            //}
            //else
            //{
            //    TempData["WelcomeMessage"] = "Hoşgeldiniz" + currentUser.Username;
            //}

            return View();
        }
        [CustomAuthorize]
        public ActionResult List()
        {
            return View(_users);
        }
        // GET: User/Details/5
        [CustomAuthorize]
        public ActionResult Details(string id)
        {
            return PartialView(_users.FirstOrDefault(x=> x.Id==id));
        }

        // GET: User/Create
        //[ChildActionOnly]
        [CustomAuthorize]
        public ActionResult Create(bool isModal=false)
        {
            if (isModal==true)
            {
                return PartialView();
            }
            else
            {
                return null;
            }
            
        }

        // POST: User/Create
        [HttpPost]
        [CustomAuthorize]
        public ActionResult Create(User user)
        {
            try
            {
                _users.Add(user);

                return RedirectToAction("List");
            }
            catch
            {
                return PartialView();
            }
        }

        // GET: User/Edit/5
        [CustomAuthorize]
        public ActionResult Edit(string id)
        {
            return PartialView(_users.FirstOrDefault(x=> x.Id==id));
        }

        // POST: User/Edit/5
        [HttpPost]
        [CustomAuthorize]
        public ActionResult Edit(string id, User user)
        {
            try
            {
                _users.RemoveAll(x=> x.Id==id);
                _users.Add(user);

                return RedirectToAction("List");
            }
            catch
            {
                return PartialView();
            }
        }

        // GET: User/Delete/5
        [CustomAuthorize]
        public ActionResult Delete(string id)
        {
            _users.RemoveAll(x=> x.Id==id);
            return RedirectToAction("List","User");
        }

    }
}