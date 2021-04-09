using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SMSS.ClassDiagram
{
    [Table("Company_Descriptions")]
    public class CompanyDescription 
    {
        [Key]
        public int Id { get; set; }
        
        public int Company { get; set; }

       
        [Column ("Company_Name")]
        public string CompanyName { get; set; }

        [Column ("Description")]
        public string Description { get; set; }
        [Column ("Time_Stamp")]
        [NotMapped]
        public Byte[] TimeStamp { get; set; }

       
        
       
        public virtual CompanyProfile CompanyProfile { get; set; }
    }
}
