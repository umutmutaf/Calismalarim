using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Entities;

namespace WebApplication4.Areas.Admin.Models
{
    public class ProductStockModel
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImgUrl { get; set; }
        public DateTime StockEntranceDate { get; set; }
        public int StockQuantity { get; set; }
        /// <summary>
        /// Product tablosunu ProductStockModel modeline çevirir.
        /// </summary>
        /// <returns></returns>

        public static List<ProductStockModel> GetList()
        {
            var products = Product.GetAllProducts();
            var returnList = new List<ProductStockModel>();
            foreach (var product in products)
            {
                ProductStockModel psm = new ProductStockModel();
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