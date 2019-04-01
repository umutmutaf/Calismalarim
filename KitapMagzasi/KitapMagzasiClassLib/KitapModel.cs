namespace KitapMagzasiClassLib
{
    using KitapMagzasiClassLib.Classes;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class KitapModel : DbContext
    {
        // Your context has been configured to use a 'KitapModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'KitapMagzasiClassLib.KitapModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'KitapModel' 
        // connection string in the application configuration file.
        public KitapModel()
            : base("name=KitapModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Kitap> Kitaplar { get; set; }
        public virtual DbSet<Kullanici> Kullaniciler { get; set; }
        public virtual DbSet<Satis> Satislar { get; set; }
        public virtual DbSet<YayinEvi> Yayinevleri { get; set; }
        public virtual DbSet<Yazar> Yazarlar { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}