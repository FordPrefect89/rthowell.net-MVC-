using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace rthowell.net__ASP_MVC_.Models
{
    public class ReloadingLedgerDBContext : DbContext
    {
        public ReloadingLedgerDBContext()
            : base("firearmsDbase")
        {
            Database.SetInitializer<ReloadingLedgerDBContext>(null);
        }

        public DbSet<ReloadingLedger> ReloadingLedger { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}