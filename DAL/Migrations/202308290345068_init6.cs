namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AuthorName = c.String(),
                        Biography = c.String(),
                        ListOfBooks = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Booklists", t => t.ListOfBooks, cascadeDelete: true)
                .Index(t => t.ListOfBooks);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GenreName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Authors", "ListOfBooks", "dbo.Booklists");
            DropIndex("dbo.Authors", new[] { "ListOfBooks" });
            DropTable("dbo.Genres");
            DropTable("dbo.Authors");
        }
    }
}
