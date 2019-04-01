using OhmCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UmutMutafBlog.Entities
{
    public class Comment:DbObject
    {
        public User YorumYapanKisi { get; set; }
        public string Icerik { get; set; }
        public bool GecerliMi { get; set; }
    }
}