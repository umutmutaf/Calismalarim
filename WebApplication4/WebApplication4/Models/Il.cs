using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Il
    {
        public string Id { get; set; }
        public string Adi { get; set; }
        public Il()
        {
            Id = Guid.NewGuid().ToString();
        }
        public override string ToString()
        {
            return Adi;
        }
        public static List<Il> GetList()
        {
            List<Il> returnList = new List<Il>();
            returnList.Add(new Il { Adi = "İstanbul" });
            returnList.Add(new Il { Adi = "Ankara" });
            returnList.Add(new Il { Adi = "Antalya" });
            return returnList;
        }
    }
}