using OhmCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseExample.Entity
{
    public class Product : DbObject
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public double Price { get; set; }
        public Stock StokInfo { get; set; }
        public Category Category { get; set; }
    }
}