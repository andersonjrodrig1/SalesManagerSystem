using SalesManagerSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagerSystem.Configuration
{
    public class UnitMeasurementConfig : EntityTypeConfiguration<UnitMeasurement>
    {
        public UnitMeasurementConfig()
        {
            ToTable("UNIT_MEASUREMENT");

            HasKey<int>(x => x.Id);
            Property(x => x.Id).HasColumnName("ID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.KeyUnit).HasColumnName("KEY_UNIT").HasColumnType("VARCHAR").HasMaxLength(20).IsRequired();
            Property(x => x.DescriptionUnit).HasColumnName("DESCRIPTION_UNIT").HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();
            Property(x => x.CalcTypeId).HasColumnName("CALC_TYPE_ID").HasColumnType("INT").IsRequired();

            HasRequired(x => x.CalcType).WithMany().HasForeignKey(x => x.CalcTypeId).WillCascadeOnDelete(false);
        }
    }
}
