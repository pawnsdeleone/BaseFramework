using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Data
{
    public class PersonIdentification
    {
        public int PersonIdentificationId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public System.DateTime DateofBirth { get; set; }
        public string Gender { get; set; }
        public string Height { get; set; }
        public Nullable<double> Weight { get; set; }
        public string EyeColor { get; set; }
        public string Nationality { get; set; }
        public string LicenseNumber { get; set; }
        public Nullable<int> LicenseTypeID { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public string RestrictionCodes { get; set; }
        public string EndorsementCodes { get; set; }
        public string AddiotionalInfo { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual LicenseType LicenseType { get; set; }
    }
}
