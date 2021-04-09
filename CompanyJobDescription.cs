using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SMSS.ClassDiagram
{
    [Table ("Company_Jobs_Descriptions")]
    public class CompanyJobDescription 
    {
        [Key]
        public int Id { get; set; }
        public int Job { get; set; }
        [Column ("Job_Name")]
        public string JobName { get; set; }
        [Column ("Job_Descriptions")]
        public string JobDescriptions { get; set; }
        [Column ("Time_Stamp")]
        [NotMapped]
        public Byte[] TimeStamp { get; set; }

        public virtual CompanyJob CompanyJob { get; set; }
       

    }
}
