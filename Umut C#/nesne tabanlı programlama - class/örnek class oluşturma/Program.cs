using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_class_oluşturma
{
   public enum CihazTipi
    {
        telefon,tablet
    }
    public class Okuyucu
    {
        public void Okuma(string klavyedenGelen)
        {
            Console.WriteLine("klavyeden okundu:"+klavyedenGelen);
        }
        public void Okuma(string dataBdengelen, string dataBAdi)
        {
            Console.WriteLine("{0} dan okundu {1} den",dataBdengelen,dataBAdi);
        }
        public void Okuma(CihazTipi e, string hangiCihaz)
        {
            Console.WriteLine("{0} cihazdan okundu {1}",e,hangiCihaz);
        }
        public void Topla(int sayi1,int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }
        public void Topla()
        {
            Console.WriteLine(8);
        }
           
    }

    class Program
    {
        static void Main(string[] args)
        {

            Okuyucu okuyucu = new Okuyucu();
            okuyucu.Okuma("mamut");
            okuyucu.Okuma(CihazTipi.tablet,"mamaut gelmiş");
            okuyucu.Okuma("mamut gelen", "northwind");
            okuyucu.Topla(1, 2);
            okuyucu.Topla();

          

            Console.ReadKey();
        }
    }
}
