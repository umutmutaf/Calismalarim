using OhmCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseExample.Entity
{
    public class User:DbObject
    {
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
        public List<CartItem> ShoppingCart { get; set; }

        public User()
        {
            //kayıt olan her kullanıcıya boş bir sepet oluştur
            ShoppingCart = new List<CartItem>();
        }

    }
}