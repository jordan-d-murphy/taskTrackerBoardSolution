namespace taskTrackerBoardProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Boards",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BoardID = c.Int(nullable: false),
                        Title = c.String(nullable: false, maxLength: 60),
                        Description = c.String(),
                        DueDate = c.DateTime(nullable: false),
                        CurrentStatus = c.Int(nullable: false),
                        Tag = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Boards", t => t.BoardID, cascadeDelete: true)
                .Index(t => t.BoardID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "BoardID", "dbo.Boards");
            DropIndex("dbo.Tasks", new[] { "BoardID" });
            DropTable("dbo.Tasks");
            DropTable("dbo.Boards");
        }
    }
}
