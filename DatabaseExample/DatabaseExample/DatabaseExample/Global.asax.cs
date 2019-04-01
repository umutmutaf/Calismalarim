using DatabaseExample.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DatabaseExample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            DbFactory.ProductCrud.CheckConnection();
            DbFactory.UserCrud.CheckConnection();
            DbFactory.StockCrud.CheckConnection();
            DbFactory.CategoryCrud.CheckConnection();
            DbFactory.TransactionCrud.CheckConnection();
            DbFactory.CartItemCrud.CheckConnection();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
