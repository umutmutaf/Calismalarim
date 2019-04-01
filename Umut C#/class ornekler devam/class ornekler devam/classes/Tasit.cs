using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_ornekler_devam
{
    
    public abstract class Tasit
    {
        public int Hiz { get; set; }
        public string Adi { get; set; }     
    }

    public class Araba : Tasit
    {
        public int BenzinKapasitesi { get; set; }

        public virtual void AracOzellik()
        {
            string ozellikler = $"Aracın hızı : {Hiz} " +
                                $"Aracın adı : {Adi} " +
                                $"Benzin kapasitesi : {BenzinKapasitesi}";
            Console.WriteLine(ozellikler);
        }
    }
    public class ElektrikliArac : Araba
    {
        public override void AracOzellik()
        {
            string ozellikler = $"Elektrikli aracın hızı : {Hiz} " +
                                $"Elektrikli aracın adı : {Adi}";
            Console.WriteLine(ozellikler);
        }
    }
}
