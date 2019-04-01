using OhmCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseExample.Entity
{
    public class Transaction:DbObject//satın alma sayfası
    {
        /// <summary>
        /// Transaction oluştuğunda giriş yapan User ın
        /// ShoppingCart ını Transaction BoughtItem Listesine aktar
        /// shoppingCart ı boşalt
        /// </summary>
        public User User { get; set; }
        public List<CartItem> BoughtItem { get; set; }//seçilen urun ve fiyat bilgisi CartItem içersinde
        public double TotalPrice
        {
            get
            {
                return BoughtItem.Sum(x => x.Product.Price*x.Quantity);
            }
        }
    }
}