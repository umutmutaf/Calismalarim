using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcilk.Models
{
    public class User
    {
        public string Id { get; set; }
        [Required(ErrorMessage ="Lütfen bir kullanıcı adı giriniz!")]
        [Display(Name ="Kullanıcı Adı")]
        [Remote("CheckIfUsernameExists","User",ErrorMessage ="Bu kullanıcı adı daha önce alınmıştır!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Lütfen bir şifre giriniz!")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage ="Şifre en az altı karakter olmalıdır!")]
        public string Password { get; set; }
        [Display(Name = "Yaş")]
        public int Age { get; set; }

        //constructer rastgele unic Id için
        public User()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}