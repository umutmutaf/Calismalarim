using SporKompleksi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporKompleksi
{ 
    public class VeriTabani
    {
        public static List<Rezervasyon> Rezerve = new List<Rezervasyon>();
        public static List<Kullanicilar> Kullanıcılar = new List<Kullanicilar>();
        public static List<Saha> Sahalar = new List<Saha>();
        private static int calistimi = 0;      
        public static void VeriTabaniniAc()
        {
            if (calistimi == 0)
            {
                calistimi++;

                //string kullaniciAdi, string sifre, string adi, string soyadi, string telefon
                Kullanıcılar.Add(new Kullanicilar("umut", "1234", "Umut", "Mutaf", "5555555555"));
                Kullanıcılar.Add(new Kullanicilar("murat", "1234", "Murat", "Culum", "5555555555"));
                Kullanıcılar.Add(new Kullanicilar("admin", "admin", "admin", "admin", "5555555555"));

                Saha item = new Saha(5, SahaTuru.Basketbol, "Sinan Erdem", "Uskudar");
                Sahalar.Add(item);
                Sahalar.Add(new Saha(10, SahaTuru.BFutbol, "TurkTelekom", "Maslak"));
                Sahalar.Add(new Saha(10, SahaTuru.KFutbol, "İnönü", "Maslak"));
                Sahalar.Add(new Saha(10, SahaTuru.Voleybol, "Eczacıbaşı", "Beylikdüzü"));
              
                Rezerve.Add(new Rezervasyon(Kullanıcılar[0], Sahalar[0], "15.01.2019", "17-18"));
                Rezerve.Add(new Rezervasyon(Kullanıcılar[1], Sahalar[0], "15.01.2019", "16-17"));
                Rezerve.Add(new Rezervasyon(Kullanıcılar[0], Sahalar[0], "15.01.2019", "18-19"));
            }
        }
    }
}
