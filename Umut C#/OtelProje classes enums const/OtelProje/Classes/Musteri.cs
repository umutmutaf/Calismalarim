using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProje.Classes
{
    class Musteri : DbObject
    {
        public Musteri()
        {

        }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Sifre { get; set; }
        public string KullaniciAdi { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string TcKimlik { get; set; }
    }
}
