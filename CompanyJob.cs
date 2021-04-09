using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SMSS.ClassDiagram
{
    [Table ("Company_Jobs")]
    public class CompanyJob 
    {
        [Key]
        public int Id { get; set; }
        public int Company { get; set; }

        [Column ("Profile_Created")]
        public DateTime ProfileCreated { get; set; }
        [Column ("Is_Inactive")]
        public Boolean IsInactive { get; set; }
        [Column ("Is_Company_Hidden")]
        public Boolean IsCompanyHidden { get; set; }
        [Column("Time_Stamp")]
        [NotMapped]
        public Byte[] TimeStamp { get; set; }

        public virtual ICollection<ApplicantJobApplication> ApplicantJobApplications { get; set; }
        public virtual ICollection<CompanyJobEducation> CompanyJobEducations { get; set; }
        public virtual ICollection<CompanyJobSkill> CompanyJobSkills { get; set; }
        public virtual CompanyProfile CompanyProfile { get; set; }
        public virtual ICollection<CompanyJobDescription> CompanyJobDescriptions { get; set; }
    }
}
