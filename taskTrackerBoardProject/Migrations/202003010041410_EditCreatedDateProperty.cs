namespace taskTrackerBoardProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditCreatedDateProperty : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tasks", "Title", c => c.String(nullable: false, maxLength: 60));
            DropColumn("dbo.Tasks", "CreatedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tasks", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Tasks", "Title", c => c.String());
        }
    }
}
