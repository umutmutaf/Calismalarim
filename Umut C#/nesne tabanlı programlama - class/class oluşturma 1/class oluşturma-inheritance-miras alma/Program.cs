using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_oluşturma_1

{
    public class Canli
    {
        public int ElSayisi;
        public int AyakSayisi;
        public string Tur;
    }
    public class Insan : Canli
    {
        public void Konus()
        {
            Console.WriteLine("selam benim {0} adet elim ve {1} adet ayağım vardır."+ElSayisi+AyakSayisi);
        }
        
    }
    public class Kopek : Canli
    {
        public void Havla()
        {
            Console.WriteLine("Auuuuu");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Insan insan = new Insan();
            Kopek kopek = new Kopek();

            insan.ElSayisi = 2;
            insan.AyakSayisi = 2;
            kopek.AyakSayisi = 4;

            insan.Konus();
            kopek.Havla();

            Console.ReadKey();

            
        }
    }
}
