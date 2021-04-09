using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CareerCloud.Pocos
{
    [Table("Company_Descriptions")]
    public class CompanyDescription 
    {
        [Key]
        public Guid Id { get; set; }
        
        public Guid Company { get; set; }

        public string LanguageId { get; set; }

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
