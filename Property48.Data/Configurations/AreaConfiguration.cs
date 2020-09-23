using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Property48.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Property48.Data.Configurations
{
    public class AreaConfiguration : IEntityTypeConfiguration<Area>
    {
        public void Configure(EntityTypeBuilder<Area> builder)
        {
            builder
            .HasKey(a => a.Id);

            builder
             .Property(m => m.Id)
             .UseIdentityColumn(50);

            builder
             .Property(a => a.Name)
             .IsRequired()
             .HasMaxLength(50);

            builder
                .ToTable("Areas");
        }
    }
}
