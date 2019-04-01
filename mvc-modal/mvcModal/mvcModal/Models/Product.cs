using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvcModal.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string ImagePath { get; set; }

        public Product()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}