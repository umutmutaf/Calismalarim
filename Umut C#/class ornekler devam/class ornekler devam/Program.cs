using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_ornekler_devam
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba();
            araba.Adi = "Wolsvagen";
            araba.Hiz = 200;
            araba.BenzinKapasitesi = 600;
            araba.AracOzellik();

            ElektrikliArac elektrikliArac = new ElektrikliArac();
            elektrikliArac.AracOzellik();
            Console.ReadKey();
        }
    }
}
