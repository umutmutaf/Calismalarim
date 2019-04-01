using codeFirst.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Model1 model1 = new Model1();
            model1.OrnekTablos.Add(new OrnekTablo
            {
                Kolon1 = "umut",
                Kolon2 = "mutaf",
                Kolon3 = "umutmutaf"
            });
            //model1.OrnekTablo2s.Add(new OrnekTablo2
            //{
            //    Kolon1 = "Muhteşem",
            //    Kolon2 = "Mutaf",
            //    Kolon3 = DateTime.Now
            //});
            //OrnekTablo ornekTablo = model1.OrnekTablos.FirstOrDefault(x => x.Id == 1);
            //ornekTablo.Kolon1 = "guncelleme umut";
            //ornekTablo.Kolon2 = "guncelleme mutaf";
            //ornekTablo.Kolon3 = "guncelleme umutmutaf";
            //model1.SaveChanges();

            //var ornekTablo = model1.OrnekTablos.Where(x=> x.Kolon1=="umut");
            //model1.OrnekTablos.RemoveRange(ornekTablo);
            //model1.SaveChanges();

            foreach (var item in model1.OrnekTablos)
            {
                Console.WriteLine(item.Kolon1+" "+item.Kolon2);
            }
            Console.ReadKey();
        
          
        }
    }
}
