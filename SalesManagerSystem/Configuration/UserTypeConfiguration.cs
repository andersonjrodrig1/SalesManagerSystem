﻿using SalesManagerSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagerSystem.Configuration
{
    public class UserTypeConfiguration : EntityTypeConfiguration<UserType>
    {
        public UserTypeConfiguration()
        {
            ToTable("USER_TYPE");

            HasKey<int>(x => x.Id);
            Property(x => x.Id).HasColumnName("ID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("NAME").HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();
        }
    }
}
