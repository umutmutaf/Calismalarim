using mvcModal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcModal.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult UrunDetay(string id)
        {
            //session dan kullanabileceğimiz hale çevirdik
            List<Product> products = Session["products"] as List<Product>;
            return View(products.FirstOrDefault(x=> x.Id==id));
        }
    }
}