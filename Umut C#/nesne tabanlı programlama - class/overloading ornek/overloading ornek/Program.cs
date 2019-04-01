using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading_ornek
{
    public class Yazici
    {
        public void Yazdir(int deger)
        {
           Console.WriteLine("tamsayı gelen değer: "+deger);
        }
        public void Yazdir(string deger)
        {
            Console.WriteLine("metinsel gelen değer: "+deger);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Yazici yazici = new Yazici();
            yazici.Yazdir(1453);
            yazici.Yazdir("Ayvansaray");
            Console.ReadKey();
        }
    }
}
