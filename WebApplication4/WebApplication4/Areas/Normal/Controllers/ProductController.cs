using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Areas.Normal.Models;

namespace WebApplication4.Areas.Normal.Controllers
{
    public class ProductController : Controller
    {
        private static List<NormalUserProductModel> _list = NormalUserProductModel.GetList();
        // GET: Normal/Product
        public ActionResult Index()
        {
            return View(_list.Skip(0).Take(30));
        }
        [HttpGet]
        public ActionResult Buy(string id)
        {
            return View((_list.FirstOrDefault(x => x.ProductId==id)));
        }
        [HttpPost]
        [CustomAuthorize(isAdmin:false)] //Giriş yapan ve admin olmayanlar alabilir ürünleri
        public ActionResult Buy(string productID, string satinAlmaAdedi)
        {
            return RedirectToAction("Result", new { productID,satinAlmaAdedi});
            //Result Actiona git yanında new içine yazılanları götür
        }
        public ActionResult Result(string productID,string satinAlmaAdedi)
        {
            var product = _list.FirstOrDefault(x => x.ProductId == productID);
            TempData["mesaj"] = satinAlmaAdedi + "adet" + product.Name + "aldınız.";
            return View();
        }
    }
}