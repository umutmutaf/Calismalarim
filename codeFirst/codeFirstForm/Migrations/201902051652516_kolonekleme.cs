namespace codeFirstForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kolonekleme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KullaniciBilgileris", "Adi", c => c.String());
            AddColumn("dbo.KullaniciBilgileris", "Soyadi", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.KullaniciBilgileris", "Soyadi");
            DropColumn("dbo.KullaniciBilgileris", "Adi");
        }
    }
}
