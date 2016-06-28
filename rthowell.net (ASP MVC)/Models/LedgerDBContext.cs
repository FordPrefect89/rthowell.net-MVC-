using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace rthowell.net__ASP_MVC_.Models
{
    public class LedgerDBContext : DbContext
    {
        public LedgerDBContext() : base("firearmDbase") { }

        public DbSet<Ledger> Ledger { get; set; }
        public DbSet<BulletInfo> BulletInfo { get; set; }
        public DbSet<PowderManufacturers> PowderManufacturers { get; set; }
        public DbSet<PrimerManufacturers> PrimerManufacturers { get; set; }
        public DbSet<ReloadingData> ReloadingData { get; set; }
        public DbSet<ReloadingLedger> ReloadingLedger { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}