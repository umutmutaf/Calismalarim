using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirstForm
{
   public class KullaniciBilgileri
    {
        [Key]
        public int KullaniciBilgileriID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Hobiler { get; set; }
        public string TelefonNo { get; set; }
    }
}
