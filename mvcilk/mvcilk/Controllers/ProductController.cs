using mvcilk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcilk.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
       
        public ActionResult Index()
        {
            var product = new Product();
            product.ProductName = "Uzay Mekiği";
            product.SupplierName = "Firma";
            product.UnitPrice = 50;
            product.LastReminderDate = DateTime.Now;

            var product1 = new Product();
            product1.ProductName = "Uzay Mekiği";
            product1.SupplierName = "Firma";
            product1.UnitPrice = 50;
            product1.LastReminderDate = DateTime.Now;

            var product2 = new Product();
            product2.ProductName = "Uzay Mekiği";
            product2.SupplierName = "Firma";
            product2.UnitPrice = 50;
            product2.LastReminderDate = DateTime.Now;

            products.Add(product);
            products.Add(product1);
            products.Add(product2);
            return View();
        }
        [HttpGet]
        public ActionResult Details(string id)
        {
            return View(products.FirstOrDefault(x => x.Id == id));
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            products.Add(product);
            TempData["Message"] = product.ProductName + "Eklendi";
            TempData["alertyazilacak"] = "<script>swal('Kullanıcı Eklendi!', '" + product.ProductName + " Eklendi!', 'success');" + "</script>";
            return RedirectToAction("ListAllProducts", "Product");
        }
        [HttpGet]
        public ActionResult Update(string id)
        {
            return View(products.FirstOrDefault(x => x.Id == id));
        }
        [HttpPost]
        public ActionResult Update(string id, Product product)
        {
            products.RemoveAll(x => x.Id == id);
            products.Add(product);
            TempData["Message"] = product.ProductName + "Güncellendi";
            TempData["alertyazilacak"] = "<script>swal('Kullanıcı Güncellendi!', '" + id + " Güncellendi!', 'success');" + "</script>";
            return RedirectToAction("ListAllProducts", "Product");
        }
        [HttpGet]
        public ActionResult Delete(string id)
        {
            products.RemoveAll(x => x.Id == id);
            TempData["Message"] = id + "Silindi";
            TempData["alertyazilacak"] = "<script>swal('Ürün Silindi!', '" + id + " Silindi!', 'success');" + "</script>";
            return RedirectToAction("ListAllProducts", "Product");
        }
        static List<Product> products = new List<Product>();
        public ActionResult ListAllProducts()
        {
            TempData["urunler"] = products;
            return View();
        }

        public JsonResult CheckIfPoductNameExists(Product product)
        {
            var IsExists = products.Any(x => x.ProductName == product.ProductName);
            /* Veritabanında bu kullanıcı adı var mı? Ona bak */
            if (IsExists == true)
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