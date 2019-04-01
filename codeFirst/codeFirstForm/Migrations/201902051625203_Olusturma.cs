namespace codeFirstForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Olusturma : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KullaniciBilgileris",
                c => new
                    {
                        KullaniciBilgileriID = c.Int(nullable: false, identity: true),
                        Hobiler = c.String(),
                        TelefonNo = c.String(),
                    })
                .PrimaryKey(t => t.KullaniciBilgileriID);
            
            CreateTable(
                "dbo.Kullanicis",
                c => new
                    {
                        KullaniciID = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(),
                        KullaniciSoyadi = c.String(),
                        DogumTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.KullaniciID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kullanicis");
            DropTable("dbo.KullaniciBilgileris");
        }
    }
}
