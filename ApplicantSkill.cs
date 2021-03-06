using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SMSS.ClassDiagram
{
    [Table("Applicant_Skills")]
    public class ApplicantSkill 
    {
        [Key]
        public int Id { get; set; }
        public int Applicant { get; set; }
        public string Skill { get; set; }

        [Column("Skill_Level")]
        public string SkillLevel { get; set; }

        [Column("Start_Month")]
        public Byte StartMonth { get; set; }

        [Column("Start_Year")]
        public Int32 StartYear { get; set; }

        [Column("End_Month")]
        public Byte EndMonth { get; set; }
        [Column("End_Year")]
        public Int32 EndYear { get; set; }
        [Column("Time_Stamp")]
        [NotMapped]
        public Byte[] TimeStamp { get; set; }
        public virtual ApplicantProfile ApplicantProfile { get; set; }
    }
}
