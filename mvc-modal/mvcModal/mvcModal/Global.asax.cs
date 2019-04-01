﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace mvcModal
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_EndRequest()
        {
            var context = new HttpContextWrapper(Context);
            if (context.Response.StatusCode==404)
            {
                context.Response.Redirect("~/Error/NotFound404");
            }
            if (context.Response.StatusCode == 401)
            {
                context.Response.Redirect("~/Error/UnAuthorized401");
            }
        }
    }
}
