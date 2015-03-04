using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace PFSheets.Models
{
    public class SavingThrow
    {
        [Required, Key, ScaffoldColumn(false)]
        public int CharID { get; set; }

        public int Character { get; set; }

        public int TypeID { get; set; }

        public string Type { get; set; }

        public int Class1Bonus { get; set; }

        public int Class2Bonus { get; set; }

        public int Class3Bonus { get; set; }

        public int Class4Bonus { get; set; }

        public int AbilityMod { get; set; }

        public int FeatMod { get; set; }

        public int MagicMod { get; set; }

        public int MiscMod { get; set; }

        public int Total { get; set; }
    }
}