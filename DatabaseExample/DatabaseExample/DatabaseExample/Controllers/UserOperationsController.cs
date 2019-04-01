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
    public class UserOperationsController : Controller
    {
        // GET: UserOperations
        public ActionResult Index()
        {
            return View(UserProductModel.GetList());
        }
        public ActionResult AddToCart(string id)
        {
            CartItem cartItem = new CartItem();
            cartItem.Product = DbFactory.ProductCrud.Find(id);
            cartItem.Quantity = 1;

            var cookie = Request.Cookies.Get("userId");
            var currentUser = UserFactory.GetCurrentUser(cookie.Value);
            currentUser.ShoppingCart.Add(cartItem);

            //biz user ın içindeki bir yapıyı değiştirdiğimiz için user ı update ediyoruz
            //entity framework arka tarafta cartItem insert işlemini yapacak
            DbFactory.UserCrud.Update(currentUser.ID, currentUser);
            return RedirectToAction("MyCart");
        }
        public ActionResult MyCart()
        {
            var cookie = Request.Cookies.Get("userId");
            var currentUser = UserFactory.GetCurrentUser(cookie.Value);
            var shoppingCart = currentUser.ShoppingCart;
            return View(shoppingCart);
        }
        public ActionResult Buy()
        {
            var cookie = Request.Cookies.Get("userId");
            var currentUser = UserFactory.GetCurrentUser(cookie.Value);
            var shoppingCart = currentUser.ShoppingCart;

            Transaction transaction = new Transaction();
            transaction.BoughtItem = shoppingCart;
            transaction.User = currentUser;
            DbFactory.TransactionCrud.Insert(transaction);

            currentUser.ShoppingCart.Clear();
            DbFactory.UserCrud.Update(currentUser.ID, currentUser);

            foreach (var item in shoppingCart)
            {
                //satın aldığımız ürünün stok adedini, alınan adet kadar azalt
                item.Product.StokInfo.Quantity -= item.Quantity;
                DbFactory.ProductCrud.Update(item.Product.ID, item.Product);
            }

            return RedirectToAction("FinalPage");
        }
        public ActionResult FinalPage()
        {
            return View();
        }
    }

}