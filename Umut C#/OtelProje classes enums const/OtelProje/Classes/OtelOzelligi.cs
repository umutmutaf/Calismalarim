using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProje.Classes
{
    public class OtelOzelligi : DbObject
    {
        public OtelOzelligi()
        {

        }
        public int OtelID { get; set; }
        public int OzellikID { get; set; }
    }
}
