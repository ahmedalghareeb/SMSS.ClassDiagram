using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SMSS.ClassDiagram
{
    [Table ("Company_Job_Skills")]
    public class CompanyJobSkill 
    {
        [Key]
        public int Id { get; set; }
        public int Job { get; set; }
        public string Skill { get; set; }
        [Column("Skill_Level")]
        public string SkillLevel { get; set; }
        public Int32 Importance { get; set; }
        [Column("Time_Stamp")]
        [NotMapped]
        public Byte[] TimeStamp { get; set; }

        public virtual CompanyJob CompanyJob { get; set; }

    }
}
