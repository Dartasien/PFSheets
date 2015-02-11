using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PFSheets.Models
{
    public class ArmorClass
    {
        [Required, Key, ScaffoldColumn(false)]
        public string TypeID { get; set; }

        [ScaffoldColumn(false)]
        public int CharID { get; set; }

        public string Type { get; set; }

        public int ArmorBonus { get; set; }

        public int ShieldBonus { get; set; }

        public int NaturalArmor { get; set; }

        public int DexMod { get; set; }

        public int DodgeBonus { get; set; }

        public int DeflectionBonus { get; set; }

        public int SizeMod { get; set; }

        public int MiscMod { get; set; }

        public int BaseAttackBonus { get; set; }

        public int StrMod { get; set; }

        public int Total { get; set; }
    }
}