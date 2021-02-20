using CanIRise.Services.PersonMS.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanIRise.Services.PersonMS.DataAccess.Concrete.EfCore.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("uuid_generate_v4()");

            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(200);

            builder.Property(x => x.Surname).IsRequired();
            builder.Property(x => x.Surname).HasMaxLength(200);

            builder.Property(x => x.Company).IsRequired();
            builder.Property(x => x.Company).HasMaxLength(200);
        }
    }
}
