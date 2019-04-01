using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneTabanliProgramlama
{
    class Tasit
    {
        public string Yakit;
        public int Hiz;
        public string Renk;
        public string Marka;

        public void TasitInfo()
        {
            Console.WriteLine("Taşıtımızın Markası: "+Marka+" Rengi: "+Renk+" Yakıt Türü: "+Yakit+" Aracın Hız Limiti: "+Hiz);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Tasit otomobil = new Tasit();

            otomobil.Marka = "Tesla";
            otomobil.Hiz = 125;
            otomobil.Renk = "Gri";
            otomobil.Yakit = "Elektrik";

            otomobil.TasitInfo();

            Console.ReadKey();
        }
    }
}
