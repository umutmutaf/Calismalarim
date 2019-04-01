using UmutMutafBlog.Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace UmutMutafBlog.Classes
{
    public class BlogModel:DbContext
    {
        public BlogModel()
            : base("name=BlogModel")
        {
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
    }
}