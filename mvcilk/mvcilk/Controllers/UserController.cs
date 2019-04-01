using mvcilk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcilk.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        //web site sayfaları
        static List<User> users = new List<User>();
        public ActionResult Index()
        {
            var user = new User();
            user.Username = "umut";
            user.Password = "123456";
            user.Age = 28;

            var user1 = new User();
            user1.Username = "mutaf";
            user1.Password = "123456";
            user1.Age = 28;

            var user2 = new User();
            user2.Username = "mutmut";
            user2.Password = "123456";
            user2.Age = 28;
            users.Add(user);
            users.Add(user1);
            users.Add(user2);
            return View();
        }
        [HttpGet]
        public ActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateUser(User user)
        {
            users.Add(user);
            TempData["Message"] = user.Username + "Eklendi";
            TempData["alertyazilacak"] = "<script>swal('Kullanıcı Eklendi!', '" + user.Username + " Eklendi!', 'success');" + "</script>";
            return RedirectToAction("ListAllUsers", "User");
            /* Veritabanına kaydet */
        }      
        [HttpGet]
        public ActionResult UserDetails(string id)
        {
            return PartialView(users.FirstOrDefault(x=> x.Id==id));
            // user ı göndermemizin nedeni details view da gösterilmesini sağlamak
        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            return View(users.FirstOrDefault(x=> x.Id==id));
        }
        [HttpPost]
        public ActionResult Edit(string id,User user)
        {
            users.RemoveAll(x => x.Id == id);
            users.Add(user);
            TempData["Message"] = user.Username + "Güncellendi";
            TempData["alertyazilacak"] = "<script>swal('Kullanıcı Güncellendi!', '" + id + " Güncellendi!', 'success');" + "</script>";
            return RedirectToAction("ListAllUsers","User");
        }
        public ActionResult ListAllUsers()
        {
            TempData["kullanicilar"] = users;
            return View();
        }
        [HttpGet]
        public ActionResult Delete(string id)
        {
            users.RemoveAll(x => x.Id == id);
            TempData["Message"] = id + "Silindi";
            TempData["image"] = "Image\\marlasinger1.jpg";
            TempData["alertyazilacak"] = "<script>swal('Kullanıcı Silindi!', '"+id+" Silindi!', 'success');"+"</script>";
            return RedirectToAction("ListAllUsers","User");
        }
        public JsonResult CheckIfUsernameExists(User user)
        {
            var IsExists = users.Any(x=> x.Username==user.Username);
            /* Veritabanında bu kullanıcı adı var mı? Ona bak */
            if (IsExists==true)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
        }
    }
}