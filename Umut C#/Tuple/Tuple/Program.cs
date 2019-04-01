using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(int first, int second, int third)> tuples = new List<(int, int, int)>();
            tuples.Add((1, 2, 4));
            tuples.Add((3, 4, 5));
            tuples.Add((3, 2, 6));

            tuples.Remove((1, 2, 4));

            foreach (var item in tuples)
            {
                Console.WriteLine(item.first + " " + item.second+" "+item.third);
            }

            tuples.RemoveAll(x => x.first==1);

            Console.ReadKey();

        }
    }
}
