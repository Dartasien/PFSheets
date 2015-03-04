namespace PFSheets.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewForeignCharacterKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AbilityScores", "Character", c => c.Int(nullable: false));
            AddColumn("dbo.ArmorClasses", "Character", c => c.Int(nullable: false));
            AddColumn("dbo.HitPoints", "Character", c => c.Int(nullable: false));
            AddColumn("dbo.Initiatives", "Character", c => c.Int(nullable: false));
            AddColumn("dbo.SavingThrows", "Character", c => c.Int(nullable: false));
            AddColumn("dbo.Speeds", "Character", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Speeds", "Character");
            DropColumn("dbo.SavingThrows", "Character");
            DropColumn("dbo.Initiatives", "Character");
            DropColumn("dbo.HitPoints", "Character");
            DropColumn("dbo.ArmorClasses", "Character");
            DropColumn("dbo.AbilityScores", "Character");
        }
    }
}
