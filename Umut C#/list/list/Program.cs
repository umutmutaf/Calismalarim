
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> yenilist = new List<int>();
            yenilist.Add(123);
            yenilist.Add(456);
            yenilist.Add(789);

            foreach (int gecici in yenilist)
            {
                Console.WriteLine(gecici);
            }


            yenilist.Remove(789);

            foreach (int gecici in yenilist)
            {
                Console.WriteLine(gecici);
            }

          

            Console.ReadKey();
        }
    }
}
