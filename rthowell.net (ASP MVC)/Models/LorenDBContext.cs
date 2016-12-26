using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace rthowell.net__ASP_MVC_.Models
{
    public class LorenDBContext : DbContext
    {
        public LorenDBContext() : base("LorenDbase") { }

        public DbSet<ExpandedLedger> ExpandedLedger { get; set; }
        public DbSet<BrassInfo> BrassInfo { get; set; }
        public DbSet<BulletInfo> BulletInfo { get; set; }
        public DbSet<BulletSpeed> BulletSpeed { get; set; }
        public DbSet<PowderManufacturers> PowderManufacturers { get; set; }
        public DbSet<PrimerManufacturers> PrimerManufacturers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}