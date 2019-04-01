using OhmCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UmutMutafBlog.Entities
{
    public class Post:DbObject
    {
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public Category Kategori { get; set; }
        public List<Comment> Yorumlar { get; set; }
        public Post()
        {
            Yorumlar = new List<Comment>();
        }
        public override string ToString()
        {
            return Baslik + Environment.NewLine + Icerik;
        }
    }
}