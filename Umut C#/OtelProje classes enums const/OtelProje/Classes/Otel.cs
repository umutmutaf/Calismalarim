using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProje.Classes
{
    public class Otel : DbObject
    {
        public Otel()
        {

        }
        public string Adi { get; set; }
        public string AdresIl { get; set; }
        public string Ilce { get; set; }
        public string Mahalle { get; set; }
        public string SirketAdi { get; set; }
        public string Aciklama { get; set; }
        public List<Yorum> Yorumlar { get; set; }
        public List<Yildiz> Yildizlar { get; set; }
        public int YildizSayisi { get; set; }
    }
}
