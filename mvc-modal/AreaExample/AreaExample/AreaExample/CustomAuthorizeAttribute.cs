using AreaExample.Areas.Normal.Controllers;
using AreaExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AreaExample
{
    public class CustomAuthorizeAttribute:AuthorizeAttribute
    {
        private bool _isAdmin { get; set; }
        public CustomAuthorizeAttribute(bool isAdmin)
        {
            _isAdmin = isAdmin;
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            var cookie = filterContext.HttpContext.Request.Cookies.Get("userId");
            if (cookie==null)
            {
                filterContext.Result = new RedirectResult("/Error/UnAuthorized401");
            }
            else
            {
                var decryptedId = OhmCryptor.OhmCryptor.Decrypt(cookie.Value, UserFactory.SuperSecretKey);
                // veritabanından userinfo yu al
                User currentUser = new User(); // veritabanından geldiğini farz edelim
                if (currentUser.UserType==UserType.Normal&&_isAdmin==true)
                    //NORMAL bir kullanıcı ADMIN  tarafına girmek istemiş
                {
                    filterContext.Result = new RedirectResult("/Error/Forbidden403");
                }

                if (currentUser.UserType == UserType.Admin && _isAdmin == false)
                //ADMIN bir kullanıcı NORMAL  tarafına girmek istemiş
                {
                    filterContext.Result = new RedirectResult("/Error/Forbidden403");
                }
            }
        }
    }
}