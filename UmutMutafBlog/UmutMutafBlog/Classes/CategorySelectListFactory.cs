using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UmutMutafBlog.Classes
{
    public class CategorySelectListFactory
    {
        public static SelectList KategoriSelectList = new SelectList(DbFactory.CategoryCrud.Records);
    }
}