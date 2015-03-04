using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PFSheets.Models
{
    public class HitPoints
    {
        [Required, Key, ScaffoldColumn(false)]
        public int CharID { get; set; }

        public int Character { get; set; }

        public int TotalHp { get; set; }

        public int DamageReduction { get; set; }

        public int EnergyResistance { get; set; }

        public int Damage { get; set; }

        public int NonLethal { get; set; }

        public int Temp { get; set; }

        public int CurrentHp { get; set; }
    }
}