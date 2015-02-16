namespace PFSheets.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addlevels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Classes", "Level1", c => c.Int(nullable: false));
            AddColumn("dbo.Classes", "Level2", c => c.Int(nullable: false));
            AddColumn("dbo.Classes", "Level3", c => c.Int(nullable: false));
            AddColumn("dbo.Classes", "Level4", c => c.Int(nullable: false));
            AddColumn("dbo.Classes", "Level5", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Classes", "Level5");
            DropColumn("dbo.Classes", "Level4");
            DropColumn("dbo.Classes", "Level3");
            DropColumn("dbo.Classes", "Level2");
            DropColumn("dbo.Classes", "Level1");
        }
    }
}
