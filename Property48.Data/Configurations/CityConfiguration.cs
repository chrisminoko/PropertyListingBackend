using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Property48.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Property48.Data.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder
                .HasKey(a => a.Id);
            builder
                .Property(a => a.Id)
                .UseIdentityColumn();

            builder.Property(a => a.Name)
                .HasMaxLength(150)
                .IsRequired();

            builder.ToTable("Cities");
        }
    }
}
