using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Data.Mapping
{
    public class PersonIdentificationMap : EntityTypeConfiguration<PersonIdentification>
    {
        public PersonIdentificationMap()
        {
            HasRequired(col => col.LicenseType).WithMany(col => col.Persons).HasForeignKey(col => col.LicenseTypeID);
        }
    }
}
