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
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("USER");

            HasKey<int>(x => x.Id);
            Property(x => x.Id).HasColumnName("ID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.UserName).HasColumnName("USER_NAME").HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();
            Property(x => x.UserLogin).HasColumnName("USER_LOGIN").HasColumnType("VARCHAR").HasMaxLength(30).IsRequired();
            Property(x => x.UserPassword).HasColumnName("USER_PASSWORD").HasColumnType("VARCHAR").HasMaxLength(15).IsRequired();
            Property(x => x.UserTypeId).HasColumnName("USER_TYPE_ID").HasColumnType("INT").IsRequired();

            HasRequired(x => x.UserType).WithMany().HasForeignKey(x => x.UserTypeId).WillCascadeOnDelete(false);
        }
    }
}
