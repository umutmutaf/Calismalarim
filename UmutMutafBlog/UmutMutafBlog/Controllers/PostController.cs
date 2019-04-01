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
    public class PostController : Controller
    {
        // GET: Post
        public ActionResult List()
        {
            return View(PostModel.GetList());
        }

        // GET: Post/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(PostModel.GetList().FirstOrDefault(x => x.Id == id));
        }

        // GET: Post/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: Post/Create
        [HttpPost]
        public ActionResult Create(PostModel collection)
        {
            try
            {
                // TODO: Add insert logic here
                var post = new Post();
                post.Baslik = collection.Baslik;
                post.Icerik = collection.Icerik;
                post.Kategori = DbFactory.CategoryCrud.Records.FirstOrDefault(x => x.KategoriAdı == collection.KategoriAdı);
                DbFactory.PostCrud.Insert(post);
                TempData["Alert"] =
              "<script>swal('Eklendi!','" + post.Baslik + "  Eklendi!', 'success'); " + "</script>";
                return RedirectToAction("List");
            }
            catch
            {
                return PartialView();
            }
        }

        // GET: Post/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView();
        }

        // POST: Post/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, PostModel collection)
        {
            try
            {
                // TODO: Add update logic here
                var post = new Post();
                post.ID = id;
                post.Baslik = collection.Baslik;
                post.Icerik = collection.Icerik;
                post.Kategori = DbFactory.CategoryCrud.Records.FirstOrDefault(x => x.KategoriAdı == collection.KategoriAdı);
                DbFactory.PostCrud.Update(id, post);
                TempData["Alert"] =
              "<script>swal('Güncellendi!','" + post.Baslik + "  Güncellendi!', 'success'); " + "</script>";
                return RedirectToAction("List");
            }
            catch
            {
                return PartialView();
            }
        }

        // GET: Post/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.PostCrud.Delete(id);
            return RedirectToAction("List");
        }
    }
}