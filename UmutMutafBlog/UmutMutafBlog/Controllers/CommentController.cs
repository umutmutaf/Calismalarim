using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UmutMutafBlog.Classes;
using UmutMutafBlog.Entities;
using UmutMutafBlog.Models;

namespace UmutMutafBlog.Controllers
{
    public class CommentController : Controller
    {
        // GET: Yorum
        public ActionResult List()
        {
            return View(CommentModel.GetList());
        }

        // GET: Yorum/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(CommentModel.GetList().FirstOrDefault(x => x.Id == id));
        }

        // GET: Yorum/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(CommentModel.GetList().FirstOrDefault(x => x.Id == id));
        }

        // POST: Yorum/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, CommentModel collection)
        {
            try
            {
                var yorum = new Comment();
                yorum.ID = id;
                yorum.Icerik = collection.Icerik;
                yorum.YorumYapanKisi = DbFactory.UserCrud.Records.FirstOrDefault(x => x.KullanıcıAdı == collection.YorumYapanUserName);
                yorum.GecerliMi = collection.GecerliMi;
                DbFactory.CommentCrud.Update(yorum.ID, yorum);
                return RedirectToAction("List");
            }
            catch
            {
                return PartialView();
            }
        }

        // GET: Yorum/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.CommentCrud.Delete(id);
            return RedirectToAction("List");
        }
    }
}