using DatabaseExample.Classes;
using DatabaseExample.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseExample.Models
{
    /// <summary>
    /// Veritabanı tablosu değildir, sadece view larda işlem kolaylığı
    /// sağlamak amacıyla oluşturulur
    /// </summary>
    public class ProductStockModel
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string CategoryName { get; set; }
        public DateTime EntranceDate { get; set; }

        public static List<ProductStockModel> GetList()
        {
            List<ProductStockModel> returnList = new List<ProductStockModel>();
            foreach (Product product in DbFactory.ProductCrud.Records)
            {
                ProductStockModel psm = new ProductStockModel();
                psm.ProductId = product.ID;
                psm.Name = product.Name;
                psm.Code = product.Code;
                psm.Price = product.Price;
                psm.Quantity = product.StokInfo.Quantity;
                psm.EntranceDate = product.StokInfo.EntranceDate;
                psm.CategoryName = product.Category.CategoryName;
                returnList.Add(psm);
            }
            return returnList;
        }
    }
}