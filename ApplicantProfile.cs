using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Profiles")]
    public class ApplicantProfile 
    {
        [Key]
        public int Id { get; set; }
        public int Login { get; set; }
       
        [Column("Country_Code")]
        public int Country { get; set; }

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

        public virtual ICollection<ApplicantEducation> ApplicantEducations { get; set; }
        public virtual ICollection<ApplicantJobApplication> ApplicantJobApplications { get; set; }
  
        public virtual ICollection<ApplicantResume> ApplicantResumes { get; set; }
        public virtual ICollection<ApplicantSkill> ApplicantSkills { get; set; }
        public virtual ICollection<ApplicantWorkHistory> ApplicantWorkHistorys { get; set; }

        public virtual City city { get; set; }
        public virtual Country country { get; set; }
        public virtual Province province { get; set; }
    }


}
