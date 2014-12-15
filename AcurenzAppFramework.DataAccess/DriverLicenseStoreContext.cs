using AcurenzAppFramework.Data;
using AcurenzAppFramework.Data.Mapping;
using Repository.Providers.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.DataAccess
{
    public class DriverLicenseStoreContext : DbContextBase
    {
         public DriverLicenseStoreContext()
            : base("Name=DriverLicenseStoreContext")
        {
            Database.SetInitializer<DriverLicenseStoreContext>(null);
            Configuration.ProxyCreationEnabled = false;
        }

         public new IDbSet<T> Set<T>() where T : class
         {
             return base.Set<T>();
         }

         public DbSet<LicenseType> LicenseTypes { get; set; }

         protected override void OnModelCreating(DbModelBuilder modelBuilder)
         {
             modelBuilder.Configurations.Add(new LicenseTypeMap());
             modelBuilder.Configurations.Add(new PersonIdentificationMap());
         }
    }
}
