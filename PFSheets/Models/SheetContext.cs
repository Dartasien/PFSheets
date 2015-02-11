using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Data.Entity;

namespace PFSheets.Models
{
    public class SheetContext : DbContext
    {
        public SheetContext() : base("PFSheets")
        {
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Initiative> Initiatives { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Speed> Speeds { get; set; }
        public DbSet<AbilityScore> AbilityScores { get; set; }
        public DbSet<ArmorClass> ArmorClasses { get; set; }
        public DbSet<HitPoints> HitPoints { get; set; }
        public DbSet<SavingThrow> SavingThrows { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}