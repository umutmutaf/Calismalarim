using DatabaseExample.Classes;
using DatabaseExample.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseExample.Models
{
    public class UserProductModel
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string CategoryName { get; set; }

        public static List<UserProductModel> GetList()
        {
            List<UserProductModel> returnList = new List<UserProductModel>();
            foreach (var product in DbFactory.ProductCrud.Records)
            {
                UserProductModel upm = new UserProductModel();
                upm.ProductId = product.ID;
                upm.Price = product.Price;
                upm.ProductName = product.Name;
                upm.Quantity = product.StokInfo.Quantity;
                upm.CategoryName = product.Category.CategoryName;
                returnList.Add(upm);
            }
            return returnList;
        }
    }
}