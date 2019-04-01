using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProje.Classes
{
    public class Yorum : DbObject
    {
        public Yorum()
        {

        }
        public int MusteriID { get; set; }
        public string YorumBasligi { get; set; }
        public string YorumIcerigi { get; set; }
        public List<Yildiz>Yizdizlar { get; set; }
    }
}
