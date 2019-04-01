using OhmCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UmutMutafBlog.Entities
{
    public class Category:DbObject
    {
        public string KategoriAdı { get; set; }

        public override string ToString()
        {
            return KategoriAdı;
        }
    }
}