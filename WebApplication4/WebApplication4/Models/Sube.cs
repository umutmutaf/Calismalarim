using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Sube
    {
        public string Id { get; set; }
        public string Kodu { get; set; }
        public Il BulunduguIl { get; set; }
        public Sube()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}