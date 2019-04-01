using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProje.Classes
{
    public class Oda : DbObject
    {
        public Oda()
        {

        }
        public int OtelID { get; set; }
        public string YorumIcerigi { get; set; }
        public bool OdaBosMu { get; set; }

    }
}
