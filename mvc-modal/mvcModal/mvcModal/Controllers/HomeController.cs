using mvcModal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcModal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                string productNumber = ((i % 5) + 1).ToString();
                Product product = new Product();
                product.ProductName = "Manzara 1" + productNumber;
                product.Price = rnd.Next(0,19);
                product.ImagePath = "../Images/" + productNumber + ".jpg";
                products.Add(product);

            }
            Session["products"] = products;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}