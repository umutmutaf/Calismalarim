using DatabaseExample.Classes;
using DatabaseExample.Entity;
using DatabaseExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseExample.Controllers
{
    public class ProductController : Controller
    {
        [CustomAuthorize(isAdmin:true)]
        public ActionResult List()
        {
            return View(ProductStockModel.GetList());
        }
        // GET: Product/Details/5
        [CustomAuthorize(isAdmin: true)]
        public ActionResult Details(string id)
        {
            return View(ProductStockModel.GetList().FirstOrDefault(x=> x.ProductId==id));
        }

        // GET: Product/Create
        [CustomAuthorize(isAdmin: true)]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [CustomAuthorize(isAdmin: true)]
        public ActionResult Create(ProductStockModel psm)
        {
            try
            {
                Product currentProduct = new Product();
                currentProduct.Code = psm.Code;
                currentProduct.Name = psm.Name;
                currentProduct.Price = psm.Price;

                Stock stock = new Stock();
                stock.EntranceDate = psm.EntranceDate;
                stock.Quantity = psm.Quantity;

                var category = DbFactory.CategoryCrud.Records.FirstOrDefault(x=> x.CategoryName==psm.CategoryName);
                currentProduct.Category = category;

                currentProduct.StokInfo = stock;
                DbFactory.ProductCrud.Insert(currentProduct);

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        [CustomAuthorize(isAdmin: true)]
        public ActionResult Edit(string id)
        {
            return View(ProductStockModel.GetList().FirstOrDefault(x => x.ProductId == id));
        }

        // POST: Product/Edit/5
        [HttpPost]
        [CustomAuthorize(isAdmin: true)]
        public ActionResult Edit(string id, ProductStockModel psm)
        {
            try
            {
                //product stock model i product tablosuna çevirdik
                Product currentProduct = DbFactory.ProductCrud.Find(id);
                currentProduct.Code = psm.Code;
                currentProduct.Name = psm.Name;
                currentProduct.Price = psm.Price;

                Stock stock = currentProduct.StokInfo;
                stock.EntranceDate = psm.EntranceDate;
                stock.Quantity = psm.Quantity;

                var category = DbFactory.CategoryCrud.Records.FirstOrDefault(x => x.CategoryName == psm.CategoryName);
                currentProduct.Category = category;

                currentProduct.StokInfo = stock;
                DbFactory.ProductCrud.Update(id,currentProduct);

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        [CustomAuthorize(isAdmin: true)]
        public ActionResult Delete(string id)
        {
            DbFactory.ProductCrud.Delete(id);
            return RedirectToAction("List");
        }
    }
}
