using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProje.Classes
{
   public class Yildiz : DbObject
    {
        public Yildiz()
        {

        }
        public int BegenmeSayisi { get; set; }
        public int BegenmemeSayisi { get; set; }
    }
}
