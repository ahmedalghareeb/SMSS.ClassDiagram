using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMSS.ClassDiagram
{
    public class City
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "{0} Is Required Field")]
        [Display(Name = "City Name", Prompt = "Enter {0}")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} Lenght Must Be between {1} and {2} character")]
        public string CityNmae { get; set; }
        public int ProvinceID { get; set; }

        public Province Province { get; set; }
    }
}