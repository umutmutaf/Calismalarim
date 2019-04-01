using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icecek__farklı_kullanımları_olan_class_lar.Classes.ClassProperties
{
    public partial class Cay : Icecek,IHazirla
    {
        public void Hazirla()
        {
            Console.WriteLine("{0} şekerli {1} çay oluşturuldu", SekerAdedi, Miktar);
        }

    }
}
