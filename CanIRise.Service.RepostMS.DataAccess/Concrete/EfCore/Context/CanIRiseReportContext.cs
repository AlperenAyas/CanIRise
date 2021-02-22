using CanIRise.Service.RepostMS.DataAccess.Concrete.EfCore.Configurations;
using CanIRise.Service.RepostMS.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanIRise.Service.RepostMS.DataAccess.Concrete.EfCore.Context
{
    public class CanIRiseReportContext : DbContext
    {
        public DbSet<Report> Reports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Host=localhost;Database=CanIRiseReport;Username=postgres;Password=1");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.HasPostgresExtension("uuid-ossp");

            modelBuilder.ApplyConfiguration(new ReportConfiguration());
        }
    }
}
