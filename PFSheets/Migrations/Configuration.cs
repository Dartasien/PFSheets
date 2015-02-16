namespace PFSheets.Migrations
{
    using PFSheets.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PFSheets.Models.SheetsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PFSheets.Models.SheetsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Characters.AddOrUpdate(
                p => new {p.PlayerName, p.CharName },
                    new Character { PlayerName = "Dart", CharName = "Dartasien"},
                    new Character { PlayerName = "Chem", CharName = "dargon"}
            );
        }
    }
}
