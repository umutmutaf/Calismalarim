using OhmCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseExample.Entity
{
    public class Stock : DbObject
    {
        public int Quantity { get; set; }
        public DateTime EntranceDate { get; set; }

    }
}