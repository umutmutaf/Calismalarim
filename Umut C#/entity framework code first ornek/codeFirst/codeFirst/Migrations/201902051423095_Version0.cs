namespace codeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrnekTabloes",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Kolon1 = c.String(),
                    Kolon2 = c.String(),
                    
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OrnekTabloes");
        }
    }
}
