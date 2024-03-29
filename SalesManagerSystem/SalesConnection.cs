namespace SalesManagerSystem
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using SalesManagerSystem.Model;
    using SalesManagerSystem.Configuration;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public partial class SalesConnection : DbContext
    {
        public SalesConnection() : base("name=SalesConnection")
        {
        }

        public virtual DbSet<UserType> userTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<CalcType> CalcTypes { get; set; }
        public virtual DbSet<UnitMeasurement> UnitMeasurements { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserTypeConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new CalcTypeConfiguration());
            modelBuilder.Configurations.Add(new UnitMeasurementConfig());

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
