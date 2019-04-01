using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProje.Classes
{
    public class Rezervasyon : DbObject
    {
        public Rezervasyon()
        {

        }
        public int MusteriID { get; set; }
        public int OdaID { get; set; }
        public int KisiSayisi { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
