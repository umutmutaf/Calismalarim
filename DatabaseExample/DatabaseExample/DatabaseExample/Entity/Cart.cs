using OhmCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseExample.Entity
{
    /// <summary>
    /// Kullanıcı sepete ekle ye tıkladığında
    /// yeni bir cartItem oluştur ve giriş yapan
    /// kullanıcının içindeki listeye ekle
    /// </summary>
    public class CartItem:DbObject
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}