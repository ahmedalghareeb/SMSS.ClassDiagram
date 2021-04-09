using CareerCloud.Pocos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
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

         [PersonalData]
         [Required]
         [Display(Name = "Residency Status")]
         public EnumResidencyStatus ResidencyStatus { get; set; }

        [PersonalData]
        [Required]
        [Display(Name = "Gender")]
        public EnumGender Gender { get; set; }

        [PersonalData]
        public string LinkedIn { get; set; }

        [PersonalData]
        public string website { get; set; }

        public ICollection<UserSector> userSectors { get; set; }
        public virtual ApplicantProfile ApplicantProfile { get; set; }

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
