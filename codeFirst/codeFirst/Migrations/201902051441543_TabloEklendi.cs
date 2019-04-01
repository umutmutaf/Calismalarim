namespace codeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabloEklendi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrnekTablo2",
                c => new
                    {
                        OrnekTablo2ID = c.Int(nullable: false, identity: true),
                        Kolon1 = c.String(),
                        Kolon2 = c.String(),
                        Kolon3 = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OrnekTablo2ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OrnekTablo2");
        }
    }
}
