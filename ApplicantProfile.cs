using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SMSS.ClassDiagram
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

        
        [Required]
        [Display(Name = "Residency Status")]
        public EnumResidencyStatus ResidencyStatus { get; set; }

        
        [Required]
        [Display(Name = "Gender")]
        public EnumGender Gender { get; set; }

        
        public string LinkedIn { get; set; }

       
        public string website { get; set; }


        public virtual ICollection<ApplicantEducation> ApplicantEducations { get; set; }
        public virtual ICollection<ApplicantJobApplication> ApplicantJobApplications { get; set; }
  
        public virtual ICollection<ApplicantResume> ApplicantResumes { get; set; }
        public virtual ICollection<ApplicantSkill> ApplicantSkills { get; set; }
        public virtual ICollection<ApplicantWorkHistory> ApplicantWorkHistorys { get; set; }

        public virtual City city { get; set; }
        public virtual Country country { get; set; }
        public virtual Province province { get; set; }

        public virtual RegisterUser user { get; set; }
    }

    public enum EnumResidencyStatus
    {
        [Display(Name = "Canadian Citizen")]
        CanadianCitizen = 1,
        [Display(Name = "Canada PR Holder")]
        CanadaPRHolder,
        [Display(Name = "Open Work Permit")]
        OpenWorkPermit,
        [Display(Name = "US Citizen")]
        USCitizen
    }

    public enum EnumGender
    {
        Male = 1,
        Female,
        Other

    }


}
