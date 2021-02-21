using CanIRise.Service.RepostMS.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CanIRise.Service.RepostMS.DataAccess.Concrete.EfCore.Configurations
{
    public class ReportConfiguration : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasDefaultValueSql("uuid_generate_v4()");

            builder.Property(x => x.CreatingTime).HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(x => x.State).IsRequired();
        }
    }
}
