using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icecek__farklı_kullanımları_olan_class_lar.Classes.ClassProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Kahve kahve = new Kahve();
            kahve.KahveTuru = KahveTuru.Cappuccino;
            kahve.Miktar = 2;
            kahve.Hazirla();
            kahve.Doldur();


            Cay cay = new Cay();
            cay.SekerAdedi = 2;
            cay.Miktar = 2;
            cay.Hazirla();
            cay.Doldur();


            Console.ReadKey();
        }
    }
}
