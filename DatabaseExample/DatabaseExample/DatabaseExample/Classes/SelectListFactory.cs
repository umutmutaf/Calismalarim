using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseExample.Classes
{
    public static class SelectListFactory
    {
        public static SelectList CategorySelectList = new SelectList(DbFactory.CategoryCrud.Records);
    }
}