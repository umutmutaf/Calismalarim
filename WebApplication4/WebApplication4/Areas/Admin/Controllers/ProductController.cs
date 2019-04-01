using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Areas.Admin.Models;
using WebApplication4.Entities;

namespace WebApplication4.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private static List<ProductStockModel> _currentList = ProductStockModel.GetList();
        // GET: Admin/Product
        [CustomAuthorize(isAdmin: true)]
        public ActionResult List()
        {
           
            return View(_currentList);
        }
        // GET: User/Details/5
        public ActionResult Details(string id)
        {
            return PartialView(_currentList.FirstOrDefault(x => x.ProductId == id));
        }
        [CustomAuthorize(isAdmin:true)]
        // GET: User/Create
        //[ChildActionOnly]
        [CustomAuthorize(isAdmin: true)]
        public ActionResult Create(bool isModal = false)
        {
            if (isModal == true)
            {
                return PartialView();
            }
            else
            {
                return null;
            }
            //return PartialView();
        }
        // POST: User/Create
        [CustomAuthorize(isAdmin: true)]
        [HttpPost]
        public ActionResult Create(ProductStockModel psm)
        {
            try
            {
                Product product = new Product();
                Stock stock = new Stock();
                product.Name = psm.Name;
                product.Price = psm.Price;
                product.ImgUrl = psm.ImgUrl;
                product.StockInfo.StockQuantity = psm.StockQuantity;
                product.StockInfo = stock;
                //Product'ı veritabanına ekle
                _currentList.Add(psm);
                return RedirectToAction("List");
                _currentList.Add(psm);

                return RedirectToAction("List");
            }
            catch
            {
                return PartialView();
            }
        }
        // GET: User/Edit/5
        [CustomAuthorize(isAdmin: true)]
        public ActionResult Edit(string id)
        {
            return PartialView(_currentList.FirstOrDefault(x => x.ProductId == id));
        }

        // POST: User/Edit/5
        [CustomAuthorize(isAdmin: true)]
        [HttpPost]
        public ActionResult Edit(string id, ProductStockModel psm)
        {
            try
            {
                //Veritabanından Sil ve ekle.

                _currentList.RemoveAll(x => x.ProductId == id);
                _currentList.Add(psm);

                return RedirectToAction("List");
            }
            catch
            {
                return PartialView();
            }
        }

        // GET: User/Delete/5
        [CustomAuthorize(isAdmin: true)]
        public ActionResult Delete(string id)
        {
            _currentList.RemoveAll(x => x.ProductId == id);

            return RedirectToAction("List");
        }
    }
}