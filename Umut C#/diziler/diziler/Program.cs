using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilarim = new int[4] { 3, 5, 7, 9 };
            for (int i = 0; i < sayilarim.Length; i++)
            {
                Console.WriteLine("{0}.eleman = {1}", i + 1, sayilarim[i]);
            }

            foreach (int gecici in sayilarim)
            {
                Console.WriteLine(gecici);
            }
            Console.ReadKey();



         
        }

    }
}
