using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcModal.Classes
{
    public class CustomAuthorizeAttribute :AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //Eğer kullanıcı var ise authorize et
            var cookie = filterContext.HttpContext.Request.Cookies.Get("userId");
            if (cookie==null)// cookie boş ise user login olmamış demektir
            {
                filterContext.Result = new RedirectResult("/Error/UnAuthorized401");
                //bu yüzden login sayfasına yönlendriyoruz
            }
            else
            {
                var decryptedId = OhmCryptor.OhmCryptor.Decrypt(cookie.Value, UserFactory.SuperSecretKey);
            }
            
            //veritabanından kontrol et id yi
        }
    }
}