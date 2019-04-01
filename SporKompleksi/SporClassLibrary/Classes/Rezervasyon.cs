using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKompleksi
{
    public class Rezervasyon : Database
    {
        public Rezervasyon(Kullanicilar kullanicilar, Saha saha, string tarih, string saat)
        {
            Kullanicilar = kullanicilar;
            Saha = saha;
            Tarih = tarih;
            Saat = saat;
        }
        public Kullanicilar Kullanicilar { get; set; }
        public Saha Saha { get; set; }
        public string Tarih { get; set; }
        public string Saat { get; set; }
    }
}
