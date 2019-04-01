namespace DatabaseExample.Contexts
{
    using DatabaseExample.Entity;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StoreContext : DbContext
    {      
        public StoreContext()
            : base("name=StoreContext")
        {
        }
         public virtual DbSet<User> Users { get; set; }
         public virtual DbSet<Product> Products { get; set; }
         public virtual DbSet<Stock> Stocks { get; set; }
         public virtual DbSet<Category> Categories { get; set; }
         public virtual DbSet<CartItem> CartItems { get; set; }
         public virtual DbSet<Transaction> Transactions { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}