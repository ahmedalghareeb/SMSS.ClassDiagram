using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SMSS.ClassDiagram
{
    public class Sector
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "{0} Is Required Field")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} Lenght Must Be between {1} and {2} character")]
        [Column("Sector_Name")]
        public string SectorName { get; set; }
    }
}
