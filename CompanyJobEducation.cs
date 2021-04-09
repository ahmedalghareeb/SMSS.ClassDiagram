using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table ("Company_Job_Educations")]
    public class CompanyJobEducation 
    {
        [Key]
        public int Id { get; set; }
        public int Job { get; set; }
        public string Major { get; set; }
        public Int16 Importance { get; set; }
        [Column ("Time_Stamp")]
        [NotMapped]
        public Byte[] TimeStamp { get; set; }
        public virtual CompanyJob CompanyJob { get; set; }
    }
}
