using CareerCloud.Pocos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMSS.ClassDiagram
{
    public class RegisterUser : IdentityUser
    {
        [PersonalData]
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} Lenght Must Be between {1} and {2} character")]
        
        public string FirstName { get; set; }

        [PersonalData]
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} Lenght Must Be between {1} and {2} character")]
        
        public string LastName { get; set; }

        [PersonalData]
        [Required]
        [StringLength(13, MinimumLength = 10)]
        [RegularExpression(@"^\\(?(\[0-9\]{3})\\)?\[-.●\]?(\[0-9\]{3})\[-.●\]?(\[0-9\]{4})$")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Provided phone number not valid")]
        public string UserPhone { get; set; }

        
        public ICollection<UserSector> userSectors { get; set; }
        

    }

}
