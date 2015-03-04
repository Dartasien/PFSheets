using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace PFSheets.Models
{
    public class Speed
    {
        [Required, Key, ScaffoldColumn(false)]
        public int CharID { get; set; }

        public int Character { get; set; }

        public int TypeID { get; set; }

        public string Type { get; set; }

        public int MoveAction { get; set; }

        public int Squares { get; set; }

        public int MilesPerHour { get; set; }

    }
}