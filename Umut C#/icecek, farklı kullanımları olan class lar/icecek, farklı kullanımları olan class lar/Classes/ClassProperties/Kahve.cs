﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace icecek__farklı_kullanımları_olan_class_lar.Classes.ClassProperties
{
    public partial class Kahve : Icecek, IHazirla
    {
        public KahveTuru KahveTuru  { get; set; }
    }    
}
