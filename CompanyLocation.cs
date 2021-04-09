using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Text;

namespace SMSS.ClassDiagram
{
    [Table("Company_Locations")]
    public class CompanyLocation 
    {
        [Key]
        public int Id { get; set; }
        public int Company { get; set; }
        [Column("Country_Code")]
        public int CountryCode { get; set; }
        [Column("State_Province_Code")]
        public int Province { get; set; }
        [Column("Street_Address")]
        public string Street { get; set; }
        [Column("City_Town")]
        public int City { get; set; }
        [Column("Zip_Postal_Code")]
        public string PostalCode { get; set; }
        [Column("Time_Stamp")]
        [NotMapped]
        public Byte[] TimeStamp { get; set; }
        public virtual CompanyProfile CompanyProfile { get; set; }

        public virtual City city { get; set; }
        public virtual Country country { get; set; }
        public virtual Province province { get; set; }

    }
}
