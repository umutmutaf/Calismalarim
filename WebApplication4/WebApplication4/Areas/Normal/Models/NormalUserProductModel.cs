using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Entities;

namespace WebApplication4.Areas.Normal.Models
{
    public class NormalUserProductModel
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImgUrl { get; set; }
        public DateTime StockEntranceDate { get; set; }
        public int StockQuantity { get; set; }

        public static List<NormalUserProductModel> GetList()
        {
            var products = Product.GetAllProducts().Where(x => x.StockInfo.StockQuantity > 0);
            var returnList = new List<NormalUserProductModel>();
            foreach (var product in products)
            {
                NormalUserProductModel psm = new NormalUserProductModel();
                psm.Name = product.Name;
                psm.ProductId = product.Id;
                psm.Price = product.Price;
                psm.ImgUrl = product.ImgUrl;
                psm.StockQuantity = product.StockInfo.StockQuantity;
                psm.StockEntranceDate = product.StockInfo.StockEntranceDate;
                returnList.Add(psm);
            }
            return returnList;
        }
    }
}