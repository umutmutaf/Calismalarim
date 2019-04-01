namespace codeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Kolon3Eklendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrnekTabloes", "Kolon3", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrnekTabloes", "Kolon3");
        }
    }
}
