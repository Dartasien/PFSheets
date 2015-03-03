namespace PFSheets.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserIDToChar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Characters", "UserID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Characters", "UserID");
        }
    }
}
