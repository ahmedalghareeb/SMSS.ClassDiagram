using System.Collections.Generic;

namespace CareerCloud.Pocos
{
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Province> Provinces { get; set; }
    }
}