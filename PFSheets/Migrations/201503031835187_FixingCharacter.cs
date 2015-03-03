namespace PFSheets.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixingCharacter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Characters", "UserID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Characters", "UserID");
        }
    }
}
