using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SMSS.ClassDiagram
{
 [Table("Applicant_Job_Applications")]
    public class ApplicantJobApplication
    {
        [Key]
        public int Id { get; set; }
        public int Applicant { get; set; }
        public int Job { get; set; }

        [Column("Application_Date")]
        public DateTime ApplicationDate { get; set; }
        
        [Column("Time_Stamp")]
        [NotMapped]
        public Byte[] TimeStamp { get; set; }

        public virtual ApplicantProfile ApplicantProfile { get; set; }
        
    }
}
