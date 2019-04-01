using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProje.Classes
{
    public class Il:DbObject
    {
        public Il()
        {

        }
        public string IlAdi { get; set; }
        public List<Ilce> Ilceler { get; set; }
    }
}
