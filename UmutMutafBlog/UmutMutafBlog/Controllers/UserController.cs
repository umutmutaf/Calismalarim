using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UmutMutafBlog.Classes;
using UmutMutafBlog.Models;

namespace UmutMutafBlog.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View(UserModel.GetList());
        }

        // GET: User/Details/5
        public ActionResult Details(string id)
        {
            return View(UserModel.GetList().FirstOrDefault(x => x.Id == id));
        }

        // GET: User/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.UserCrud.Delete(id);
            return View();
        }
    }
}