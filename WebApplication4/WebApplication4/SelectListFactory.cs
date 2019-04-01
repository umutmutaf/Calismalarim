using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4
{
    public static class SelectListFactory
    {
        public static SelectList IlSelectList = new SelectList(Models.Il.GetList());
    }
}