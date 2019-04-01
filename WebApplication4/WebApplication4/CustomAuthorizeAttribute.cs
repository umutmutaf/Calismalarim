using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Areas.Normal.Controllers;
using WebApplication4.Models;

namespace WebApplication4
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
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
                filterContext.Result = new RedirectResult("/Normal/LoginRegister/login");
            }
            else
            {
                var decryptedId = OhmCryptor.OhmCryptor.Decrypt(cookie.Value,UserFactory.SuperSecretKey);
                User currentUser = new User();//veritabından geldiğini düşün
                //currentUser.UserType = UserType.Admin;
                currentUser.UserType = UserType.Normal;
                if (currentUser.UserType==UserType.Normal && _isAdmin==true)
                {
                    //redirect to 401 UnAuthorized
                    filterContext.Result = new RedirectResult("/Error/Forbidden");
                }
                else if (currentUser.UserType==UserType.Admin && _isAdmin==false)
                {
                    //redirect 
                    filterContext.Result = new RedirectResult("/Error/Forbidden");
                }
            }
        }
    }
}