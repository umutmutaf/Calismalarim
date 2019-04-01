using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_oluşturma_poliformizm
{
    enum CanliTip
    {
        Insan = 0,
        Hayvan = 1
    }

    [Flags]  // bir enum dan birden fazla değişken alabilmek için - iki değişkeni birleştirip yazırmak için
    enum Hareket
    {
        Havla = 0,
        KuyrukSalla = 2,
        PatiUzat = 4
    }

    class Program
    {
        static void Konus(CanliTip e, string ifade)
        {
            Console.WriteLine("{0} der ki: '{1}'", e, ifade);
        }
        static void Konus(string ifade)
        {
            Console.WriteLine(ifade);
        }
        static void Konus(CanliTip e,Hareket f)
        {
            Console.WriteLine("{0} şunu yaptı: {1}",e,f);
        }

        static void Main(string[] args)
        {
            //Konus("hav hav");
            //Konus(CanliTip.Hayvan, Hareket.KuyrukSalla);
            //Konus(CanliTip.Insan,"ben insanım");

            Hareket topluHareket = Hareket.Havla | Hareket.KuyrukSalla;  //enum a flags ekledikten sonraki kullanım
            Hareket havlamasizHareket = topluHareket ^ Hareket.Havla;
            Konus(CanliTip.Hayvan, topluHareket);
            Konus(CanliTip.Hayvan, havlamasizHareket);
          
            Console.ReadKey();
        }
    }
}
