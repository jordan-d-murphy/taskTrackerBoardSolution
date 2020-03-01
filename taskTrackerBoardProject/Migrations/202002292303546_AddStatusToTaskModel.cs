namespace taskTrackerBoardProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatusToTaskModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "CurrentStatus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "CurrentStatus");
        }
    }
}
