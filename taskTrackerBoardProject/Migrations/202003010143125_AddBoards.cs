namespace taskTrackerBoardProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBoards : DbMigration
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
            
            AddColumn("dbo.Tasks", "BoardID", c => c.Int(nullable: false));
            CreateIndex("dbo.Tasks", "BoardID");
            AddForeignKey("dbo.Tasks", "BoardID", "dbo.Boards", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "BoardID", "dbo.Boards");
            DropIndex("dbo.Tasks", new[] { "BoardID" });
            DropColumn("dbo.Tasks", "BoardID");
            DropTable("dbo.Boards");
        }
    }
}
