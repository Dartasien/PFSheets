using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PFSheets.Models
{
    public class Initiative
    {
        [Required, Key, ScaffoldColumn(false)]
        public int CharID { get; set; }

        public int DexMod { get; set; }

        public int FeatMod { get; set; }

        public int RaceMod { get; set; }

        public int MiscMod { get; set; }

        public int Total { get; set; }
    }
}