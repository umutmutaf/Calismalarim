using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProje.Classes
{
    public class DbObject
    {
        public DbObject()
        {

        }    
        public string ID { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public string OlusturanKisi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public string GuncelleyenKisi { get; set; }
    }
}
