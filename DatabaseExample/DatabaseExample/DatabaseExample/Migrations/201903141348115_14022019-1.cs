namespace DatabaseExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _140220191 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CartItems",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Quantity = c.Int(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                        Product_ID = c.String(maxLength: 128),
                        Transaction_ID = c.String(maxLength: 128),
                        User_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.Product_ID)
                .ForeignKey("dbo.Transactions", t => t.Transaction_ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.Product_ID)
                .Index(t => t.Transaction_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Code = c.String(),
                        Price = c.Double(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                        Category_ID = c.String(maxLength: 128),
                        StokInfo_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.Category_ID)
                .ForeignKey("dbo.Stocks", t => t.StokInfo_ID)
                .Index(t => t.Category_ID)
                .Index(t => t.StokInfo_ID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        CategoryName = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Quantity = c.Int(nullable: false),
                        EntranceDate = c.DateTime(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                        User_ID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        Fullname = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        UserType = c.Int(nullable: false),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        OlusturanKisi = c.String(maxLength: 50),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "User_ID", "dbo.Users");
            DropForeignKey("dbo.CartItems", "User_ID", "dbo.Users");
            DropForeignKey("dbo.CartItems", "Transaction_ID", "dbo.Transactions");
            DropForeignKey("dbo.CartItems", "Product_ID", "dbo.Products");
            DropForeignKey("dbo.Products", "StokInfo_ID", "dbo.Stocks");
            DropForeignKey("dbo.Products", "Category_ID", "dbo.Categories");
            DropIndex("dbo.Transactions", new[] { "User_ID" });
            DropIndex("dbo.Products", new[] { "StokInfo_ID" });
            DropIndex("dbo.Products", new[] { "Category_ID" });
            DropIndex("dbo.CartItems", new[] { "User_ID" });
            DropIndex("dbo.CartItems", new[] { "Transaction_ID" });
            DropIndex("dbo.CartItems", new[] { "Product_ID" });
            DropTable("dbo.Users");
            DropTable("dbo.Transactions");
            DropTable("dbo.Stocks");
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
            DropTable("dbo.CartItems");
        }
    }
}
