using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class__inhare_vs
{
    public enum BedenOzel
    {
            XXS,
            XS,
            S,
            M,
            L,
            XL,
            XXL
    }
   public class Urun
    {
        public string UrunAdi;
        public int Fiyat;
        public int StokAdedi;
        public void UrunOzellik()
        {
            Console.WriteLine("ürün adı: {0}, fiyatı: {1}, stok adedi: {2}",UrunAdi,Fiyat,StokAdedi);
        }
        public void Sat(int Adet)
        {
            StokAdedi -= Adet;
        }
    }
    public class Yiyecek : Urun
    {
        public DateTime SonKullanimTarihi;
        public DateTime UretimTarihi;
        public void RafaYerlestir()
        {
            Console.WriteLine("uretim tarihi: {0}, son kullanım tarihi: {1}",UretimTarihi,SonKullanimTarihi);
        }
    }
    public class Giyecek : Urun
    {
        public BedenOzel beden;
        public void RafaYerlestir()
        {
            Console.WriteLine("bedeni {0} olan ürün rafa yerleştirildi. ",beden);
        }
    }
}
