namespace PFSheets.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixingCharacterAgain : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Characters", "UserID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Characters", "UserID", c => c.Int(nullable: false));
        }
    }
}
