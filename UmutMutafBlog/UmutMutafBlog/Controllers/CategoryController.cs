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
    public class CategoryController : Controller
    {
        // GET: Kategori
        public ActionResult List()
        {
            return View(CategoryModel.GetList());
        }
        // GET: Kategori/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(CategoryModel.GetList().FirstOrDefault(x => x.Id == id));
        }
        // GET: Kategori/Create
        public ActionResult Create()
        {
            return PartialView();
        }
        // POST: Kategori/Create
        [HttpPost]
        public ActionResult Create(CategoryModel collection)
        {
            try
            {
                var kategori = new Category();
                kategori.KategoriAdı = collection.KategoriAdı;
                DbFactory.CategoryCrud.Insert(kategori);
                TempData["Alert"] =
              "<script>swal('Eklendi!','" + kategori.KategoriAdı + "  kategori Eklendi!', 'success'); " + "</script>";
                return RedirectToAction("List");

            }
            catch
            {
                return PartialView();
            }
        }

        // GET: Kategori/Edit/5
        public ActionResult Edit(string id)
        {
            return PartialView(CategoryModel.GetList().FirstOrDefault(x => x.Id == id));
        }

        // POST: Kategori/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, CategoryModel collection)
        {
            try
            {
                var kategori = new Category();
                kategori.KategoriAdı = collection.KategoriAdı;
                kategori.ID = id;
                DbFactory.CategoryCrud.Update(id, kategori);
                TempData["Alert"] =
           "<script>swal('Güncellendi!','" + kategori.KategoriAdı + "  kategori Güncellendi!', 'success'); " + "</script>";
                return RedirectToAction("List");
            }
            catch
            {
                return PartialView();
            }
        }

        // GET: Kategori/Delete/5
        public ActionResult Delete(string id)
        {
            DbFactory.CategoryCrud.Delete(id);
            return RedirectToAction("List");
        }
    }
}