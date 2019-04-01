using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace range_kullanım
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> squares = Enumerable.Range(1,10).Select(x=> x*x);
            foreach (var item in squares)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
