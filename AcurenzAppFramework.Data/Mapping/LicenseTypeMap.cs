using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcurenzAppFramework.Data.Mapping
{
    public class LicenseTypeMap : EntityTypeConfiguration<LicenseType>
    {
        public LicenseTypeMap()
        {

            this.Property(t => t.DisplayName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LookupName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(50);

            this.Property(t => t.UpdatedBy)
                .IsOptional()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("LicenseTypes");
            this.Property(t => t.LicenseTypeID).HasColumnName("LicenseTypeID");
            this.Property(t => t.DisplayName).HasColumnName("DisplayName");
            this.Property(t => t.LookupName).HasColumnName("LookupName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.active).HasColumnName("active");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.UpdatedBy).HasColumnName("UpdatedBy");
        }
    }
}
