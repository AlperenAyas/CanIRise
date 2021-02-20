using CanIRise.Services.PersonMS.DataAccess.Concrete.EfCore.Configurations;
using CanIRise.Services.PersonMS.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanIRise.Services.PersonMS.DataAccess.Concrete.EfCore.Context
{
    public class CanIRiseContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql("Host=localhost;Database=CanIRise;Username=postgres;Password=1");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.HasPostgresExtension("uuid-ossp");

            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new ContactTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
        }
    }
}
