using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Entities
{
    public class Product
    {
        public string  Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImgUrl { get; set; }
        public Stock StockInfo { get; set; }
        public Product()
        {
            Id = Guid.NewGuid().ToString();
        }
        public static List<Product> GetAllProducts()
        {
            Random rnd = new Random();
            List<Product> returnList = new List<Product>();
            for (int i = 0; i < 100; i++)
            {
                Product product = new Product();
                product.Name = "Ürün" + i;
                product.Price = rnd.Next(15, 350);
                product.ImgUrl = "https://pbs.twimg.com/profile_images/828919188047671296/ZaM87OI6_400x400.jpg";

                Stock stock = new Stock();
                stock.StockEntranceDate = new DateTime(2019, rnd.Next(1, 13), 1);
                stock.StockQuantity = rnd.Next(0, 50);

                product.StockInfo = stock;
                returnList.Add(product);
            }
            return returnList;
        }
    }
}