using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace CareerCloud.Pocos
{
    public class Province
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "{0} Is Required Field")]
        [Display(Name = "Province Name", Prompt = "Enter {0}")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "{0} Lenght Must Be between {1} and {2} character")]
        public string ProvinceName { get; set; }

        public int CountryID { get; set; }

        public Country Country { get; set; }
        public ICollection<City> Cities { get; set; }
        public ICollection<RegisterUser> ApplicationUsers { get; set; }
    }
}