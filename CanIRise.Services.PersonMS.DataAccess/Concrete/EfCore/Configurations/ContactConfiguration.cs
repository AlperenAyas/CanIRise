using CanIRise.Services.PersonMS.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanIRise.Services.PersonMS.DataAccess.Concrete.EfCore.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("uuid_generate_v4()");

            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.Content).HasMaxLength(200);

            builder.HasOne(x => x.Person).WithMany(x => x.Contacts).HasForeignKey(x => x.PersonId).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.ContactType).WithMany(x => x.Contacts).HasForeignKey(x => x.ContactTypeId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
