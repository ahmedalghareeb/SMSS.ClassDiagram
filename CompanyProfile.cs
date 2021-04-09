using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Company_Profiles")]
    public class CompanyProfile 
    {
        [Key]
        public int Id { get; set; }
        [Column("Company_Website")]
        public string CompanyWebsite { get; set; }
        [Column("Contact_Phone")]
        public string ContactPhone { get; set; }
        [Column("Contact_Name")]
        public string ContactName { get; set; }
        [Column("Company_Logo")]
        public Byte[] CompanyLogo { get; set; }
        [Column("Time_Stamp")]
        [NotMapped]
        public Byte[] TimeStamp { get; set; }
        public virtual ICollection<CompanyDescription> CompanyDescriptions { get; set; }
        public virtual ICollection<CompanyJob> CompanyJobs { get; set; }
        public virtual ICollection<CompanyLocation> CompanyLocations { get; set; }
    }
}
