using DatabaseExample.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseExample.Classes
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
            if (cookie == null)
            {
                filterContext.Result = new RedirectResult("/Normal/LoginRegister/login");
            }
            else
            {
                var decryptedId = OhmCryptor.OhmCryptor.Decrypt(cookie.Value, UserFactory.SuperSecretKey);
                User currentUser = DbFactory.UserCrud.Find(decryptedId);
               
                if (currentUser.UserType == UserType.Bireysel && _isAdmin == true)
                {
                    filterContext.Result = new RedirectResult("/Error/Forbidden403");
                }
                else if (currentUser.UserType == UserType.Kurumsal && _isAdmin == false)
                {
                    filterContext.Result = new RedirectResult("/Error/Forbidden403");
                }
            }
        }
    }
}