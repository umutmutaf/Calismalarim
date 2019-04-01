
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ornekler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[] { 5, 4, 1, 9, 6, 8, 7, 2, 3,6 };

            var kucukSayilar = sayilar.Where(sayi=>sayi<5);

            Console.WriteLine("ilk çalıştırma 5 ten küçükler");
            foreach (var sayi in kucukSayilar)
            {
                Console.WriteLine(sayi);
            }
            // dizideki elemanları negatife çeviriyoruz
            for (int i = 0; i < 10; i++)
            {
                sayilar[i] = sayilar[i] * -1;
            }

            Console.WriteLine("ikinci çalıştırma 5 ten küçükler");
            foreach (int sayi in kucukSayilar)
            {
                Console.WriteLine(sayi);
            }
            Console.ReadKey();
        
        }
    }
}
