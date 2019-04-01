using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProje.Classes
{
    public  class OtelResimleri : DbObject
    {
        public OtelResimleri()
        {

        }
        public int OtelID { get; set; }
        public Byte[] Resim { get; set; }
    }
}
