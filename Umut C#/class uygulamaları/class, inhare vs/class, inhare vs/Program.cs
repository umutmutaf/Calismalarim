using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class__inhare_vs
{
    class Program
    {
        static void Main(string[] args)
        {
            Yiyecek yiyecek = new Yiyecek();
            yiyecek.UrunAdi = "elma";
            yiyecek.Fiyat = 10;
            yiyecek.SonKullanimTarihi = Convert.ToDateTime("12.12.2056");
            yiyecek.UretimTarihi= Convert.ToDateTime("12.12.2012");
            yiyecek.StokAdedi = 20;
            yiyecek.RafaYerlestir();
            yiyecek.Sat(2);
            yiyecek.UrunOzellik();
            Console.ReadKey();
        }
    }
}
