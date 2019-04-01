using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirst.Model.Entity
{
    public class OrnekTablo2
    {
        [Key]
        public int OrnekTablo2ID { get; set; }
        [MaxLength(50)]
        public string Kolon1 { get; set; }
        public string Kolon2 { get; set; }
        public DateTime Kolon3 { get; set; }

    }
}
