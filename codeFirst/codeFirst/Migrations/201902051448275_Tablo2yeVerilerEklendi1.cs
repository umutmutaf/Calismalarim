namespace codeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tablo2yeVerilerEklendi1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrnekTablo2", "Kolon1", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrnekTablo2", "Kolon1", c => c.String());
        }
    }
}
