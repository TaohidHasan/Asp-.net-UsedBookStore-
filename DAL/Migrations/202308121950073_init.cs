namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Booklists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookName = c.String(),
                        BookCondition = c.String(),
                        Category = c.String(),
                        Book_details = c.String(),
                        Author_Name = c.String(),
                        SellerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SellerRegistrations", t => t.SellerID, cascadeDelete: true)
                .Index(t => t.SellerID);
            
            CreateTable(
                "dbo.SellerRegistrations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        uname = c.String(nullable: false),
                        gender = c.String(),
                        DOB = c.DateTime(nullable: false),
                        phone = c.String(),
                        user_type = c.String(),
                        shop_name = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Booklists", "SellerID", "dbo.SellerRegistrations");
            DropIndex("dbo.Booklists", new[] { "SellerID" });
            DropTable("dbo.SellerRegistrations");
            DropTable("dbo.Booklists");
        }
    }
}
