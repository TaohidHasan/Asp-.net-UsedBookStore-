namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BuyerRegistrations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        gender = c.String(),
                        DOB = c.DateTime(nullable: false),
                        phone = c.String(),
                        user_type = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PaymentMethods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        pay_method = c.String(),
                        amount = c.String(),
                        BuyerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BuyerRegistrations", t => t.BuyerID, cascadeDelete: true)
                .Index(t => t.BuyerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PaymentMethods", "BuyerID", "dbo.BuyerRegistrations");
            DropIndex("dbo.PaymentMethods", new[] { "BuyerID" });
            DropTable("dbo.PaymentMethods");
            DropTable("dbo.BuyerRegistrations");
        }
    }
}
