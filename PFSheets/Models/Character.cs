using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PFSheets.Models
{
    public class Character
    {
        [Required, Key, StringLength(15)]
        public string PlayerName { get; set; }

        [Required, StringLength(15)]
        public string CharName { get; set; }

        [Required, ScaffoldColumn(false)]
        public int CharID { get; set; }

        public string Race { get; set; }

        public string Deity { get; set; }

        public string Alignment { get; set; }

        /*
        public ICollection<AbilityScore> AbilityScores { get; set; }

        public ICollection<Class> Classes { get; set; }

        public HitPoints HitPoints { get; set; }

        public ICollection<Initiative> Initiatives { get; set; }

        public ICollection<SavingThrow> SavingThrows { get; set; }

        public ICollection<Speed> Speeds { get; set; }

        public ICollection<ArmorClass> ArmorClasses { get; set; } 
         */

    }
}