using OhmCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseExample.Entity
{
    public class Category:DbObject
    {
        public string CategoryName { get; set; }
        public override string ToString()
        {
            return CategoryName.ToString();
        }
    }
}