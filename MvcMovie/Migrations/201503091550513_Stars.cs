namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Stars : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MovieId = c.Int(nullable: false),
                        AspNetUsersId = c.Int(nullable: false),
                        Stars = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stars");
        }
    }
}
