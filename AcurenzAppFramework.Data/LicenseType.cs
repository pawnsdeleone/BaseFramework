using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Data
{
    public class LicenseType:EntityBase
    {
        public int LicenseTypeID { get; set; }
        public string DisplayName { get; set; }
        public string LookupName { get; set; }
        public string Description { get; set; }
        public bool active { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string UpdatedBy { get; set; }

        public ICollection<PersonIdentification> Persons { get; set; }
    }
}
