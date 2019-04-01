using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcilk.Models
{
    public class Product
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Lütfen bir ürün adı giriniz!")]
        [Display(Name = "Ürün Adı")]
        [Remote("CheckIfUsernameExists", "User", ErrorMessage = "Bu kullanıcı adı daha önce alınmıştır!")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Lütfen bir tedarikçi adı giriniz!")]
        [Display(Name = "Tedarikçi Adı")]
        public string SupplierName { get; set; }

        [Required(ErrorMessage = "Lütfen ürün fiyatını giriniz!")]
        [Display(Name = "Ürün Fiyatı")]
        public double UnitPrice { get; set; }

        [Required(ErrorMessage = "Lütfen Son Tüketim Tarihi giriniz!")]
        [Display(Name = "Son Tüketim Tarihi")]
        public DateTime LastReminderDate { get; set; }

        public Product()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}