using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PFSheets.Models
{
    public class AbilityScore
    {
        [Required, Key, ScaffoldColumn(false)]
        public int CharID { get; set; }

        public int TypeID { get; set; }

        public string Type { get; set; }

        public int Score { get; set; }

        public int ScoreMod { get; set; }

        public int Bonus { get; set; }

        public int BonusMod { get; set; }

        public int DamagePenalty { get; set; }

        public int DamagePenaltyMod { get; set; }

    }
}