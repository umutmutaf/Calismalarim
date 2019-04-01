namespace KitapMagzasiClassLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kitaps",
                c => new
                    {
                        KitapId = c.String(nullable: false, maxLength: 128),
                        Adi = c.String(),
                        KitapTuru = c.Int(nullable: false),
                        SayfaSayisi = c.Int(nullable: false),
                        Fiyat = c.Double(nullable: false),
                        BaskiYili = c.Int(nullable: false),
                        YayinEvi_YayinEviId = c.String(maxLength: 128),
                        Yazar_YazarId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.KitapId)
                .ForeignKey("dbo.YayinEvis", t => t.YayinEvi_YayinEviId)
                .ForeignKey("dbo.Yazars", t => t.Yazar_YazarId)
                .Index(t => t.YayinEvi_YayinEviId)
                .Index(t => t.Yazar_YazarId);
            
            CreateTable(
                "dbo.YayinEvis",
                c => new
                    {
                        YayinEviId = c.String(nullable: false, maxLength: 128),
                        YayinEviAdi = c.String(),
                    })
                .PrimaryKey(t => t.YayinEviId);
            
            CreateTable(
                "dbo.Yazars",
                c => new
                    {
                        YazarId = c.String(nullable: false, maxLength: 128),
                        AdiSoyadi = c.String(),
                        DogumTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.YazarId);
            
            CreateTable(
                "dbo.Kullanicis",
                c => new
                    {
                        KullaniciId = c.String(nullable: false, maxLength: 128),
                        Adi = c.String(),
                        Soyadi = c.String(),
                        KullaniciAdi = c.String(),
                        Sifre = c.String(),
                    })
                .PrimaryKey(t => t.KullaniciId);
            
            CreateTable(
                "dbo.Satis",
                c => new
                    {
                        SatisId = c.String(nullable: false, maxLength: 128),
                        SatisTarihi = c.DateTime(nullable: false),
                        HediyeMi = c.Boolean(nullable: false),
                        AlınanKitap_KitapId = c.String(maxLength: 128),
                        SatinAlanKullanici_KullaniciId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.SatisId)
                .ForeignKey("dbo.Kitaps", t => t.AlınanKitap_KitapId)
                .ForeignKey("dbo.Kullanicis", t => t.SatinAlanKullanici_KullaniciId)
                .Index(t => t.AlınanKitap_KitapId)
                .Index(t => t.SatinAlanKullanici_KullaniciId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Satis", "SatinAlanKullanici_KullaniciId", "dbo.Kullanicis");
            DropForeignKey("dbo.Satis", "AlınanKitap_KitapId", "dbo.Kitaps");
            DropForeignKey("dbo.Kitaps", "Yazar_YazarId", "dbo.Yazars");
            DropForeignKey("dbo.Kitaps", "YayinEvi_YayinEviId", "dbo.YayinEvis");
            DropIndex("dbo.Satis", new[] { "SatinAlanKullanici_KullaniciId" });
            DropIndex("dbo.Satis", new[] { "AlınanKitap_KitapId" });
            DropIndex("dbo.Kitaps", new[] { "Yazar_YazarId" });
            DropIndex("dbo.Kitaps", new[] { "YayinEvi_YayinEviId" });
            DropTable("dbo.Satis");
            DropTable("dbo.Kullanicis");
            DropTable("dbo.Yazars");
            DropTable("dbo.YayinEvis");
            DropTable("dbo.Kitaps");
        }
    }
}
