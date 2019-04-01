using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Entities
{
    public class Stock
    {
        public string Id { get; set; }
        public DateTime StockEntranceDate { get; set; }
        public int StockQuantity { get; set; }
        public Stock()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}