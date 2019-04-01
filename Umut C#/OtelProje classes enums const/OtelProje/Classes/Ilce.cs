using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProje.Classes
{
    public class Ilce : DbObject
    {
        public Ilce()
        {

        }
        public string IlceAdi { get; set; }
        public List<Mahalle> Mahalleler { get; set; }
    }
}
