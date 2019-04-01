using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_console_uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            // tek sayıları gösterme farklı yollarla

            /*1*/

            //var liste = new int[] { 1, 3, 33, 44, 56, 101 };
            //var tekler = from sayi in liste where sayi % 2 == 1 select sayi;

            //foreach (var teksayi in tekler)
            //{
            //    Console.WriteLine(teksayi);
            //}
            //Console.ReadKey();

            /*2*/ //lamnda => ile

            //var liste = new int[] { 1, 3, 33, 44, 56, 101 };
            //var tekler = liste.Where(sayi => sayi % 2 == 1);

            //foreach (var teksayi in tekler)
            //{
            //    Console.WriteLine(teksayi);
            //}
            //Console.ReadKey();

            //var Ogrenciler = Kayit.OgrencileriGetir();

            // ogrenci nin tek bir özelliğini kullanacaksak
            // var ogrenciIsimleri = Ogrenciler.Select(ogrenci=> ogrenci.DogumTarihi); 

            // birden fazla özellik gösterilecekse new ile
            //var ogrenciIsimleri = Ogrenciler.Select(ogrenci => new {ogrenci.Adi,ogrenci.Soyadi,ogrenci.DogumTarihi });

            //var ogrenciIsimleri = Ogrenciler.Select(ogrenci => ogrenci.Ortalama).Where(ortalama=>ortalama>=55);

            //foreach (var item in ogrenciIsimleri)
            //{
            //    Console.WriteLine(item);
            //}
            /************************************************************************************/
            //var Ogrenciler = Kayit.OgrencileriGetir();

            //var OgrenciListesi = Ogrenciler.Where((Ogrenci, Index) => Ogrenci.No == Index + 1);

            //Console.WriteLine("listede nuraması ile aynı sırada bulunan öğrenciler...");

            //foreach (var ListeSatiri in OgrenciListesi)
            //{
            //    Console.WriteLine("{0}-{1},{2}",ListeSatiri.No,ListeSatiri.Soyadi,ListeSatiri.Adi);
            //}
            /*************************************************************************************/
            // Select dönüştürme(transformation)
            //var Ogrenciler = Kayit.OgrencileriGetir();
            //var Kulupler = Kayit.KulupleriGetir();
            //var OgrencilerVeKulupleri = Ogrenciler.Select(Ogrenci => Ogrenci.Adi + ":" + Kulupler[Ogrenci.Kulup].Adi);

            //Console.WriteLine("öğrencilerin üye olduğu kulupler");

            //foreach (var Satir in OgrencilerVeKulupleri)
            //{
            //    Console.WriteLine(Satir);
            //}
            /**************************************************************************/
            

            var Ogrenciler = Kayit.OgrencileriGetir();
            var OgrenciListesi = Ogrenciler.Select((Ogrenci, Index) => new { Sirasi = Index + 1, Ogrenci.No, Ogrenci.Adi, Soyadim = Ogrenci.Soyadi });

            Console.WriteLine("Öğrenci listesi: ");
            foreach (var ListeSatiri in OgrenciListesi)
            {
                Console.WriteLine("{0}-{1} {2} {3}",ListeSatiri.Sirasi,ListeSatiri.No,ListeSatiri.Adi,ListeSatiri.Soyadim);
            }


            Console.ReadKey();
        }
    }
}
