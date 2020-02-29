namespace taskTrackerBoardProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTagPropertyToTask : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tasks", "Tag", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tasks", "Tag");
        }
    }
}
