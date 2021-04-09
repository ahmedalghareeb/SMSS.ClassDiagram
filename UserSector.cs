using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMSS.ClassDiagram
{
    public class UserSector
    {
        public int ID { get; set; }
        public string UserId { get; set; }
        public RegisterUser registeredUser { get; set; }

        public int SectorID { get; set; }
        public Sector Sector { get; set; }

        public virtual ICollection<Sector> sectors { get; set; }
    }
}
