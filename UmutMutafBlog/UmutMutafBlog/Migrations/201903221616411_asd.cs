namespace UmutMutafBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        KategoriAdı = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Icerik = c.String(),
                        GecerliMi = c.Boolean(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                        YorumYapanKisi_ID = c.String(maxLength: 128),
                        Post_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.YorumYapanKisi_ID)
                .ForeignKey("dbo.Posts", t => t.Post_ID)
                .Index(t => t.YorumYapanKisi_ID)
                .Index(t => t.Post_ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Ad = c.String(),
                        Soyad = c.String(),
                        KullanıcıAdı = c.String(),
                        Sifre = c.String(),
                        Email = c.String(),
                        DogumTarihi = c.DateTime(nullable: false),
                        UserType = c.Int(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Baslik = c.String(),
                        Icerik = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                        Kategori_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.Kategori_ID)
                .Index(t => t.Kategori_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "Post_ID", "dbo.Posts");
            DropForeignKey("dbo.Posts", "Kategori_ID", "dbo.Categories");
            DropForeignKey("dbo.Comments", "YorumYapanKisi_ID", "dbo.Users");
            DropIndex("dbo.Posts", new[] { "Kategori_ID" });
            DropIndex("dbo.Comments", new[] { "Post_ID" });
            DropIndex("dbo.Comments", new[] { "YorumYapanKisi_ID" });
            DropTable("dbo.Posts");
            DropTable("dbo.Users");
            DropTable("dbo.Comments");
            DropTable("dbo.Categories");
        }
    }
}
