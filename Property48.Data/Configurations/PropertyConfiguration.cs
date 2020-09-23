using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Property48.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Property48.Data.Configurations
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder
                 .HasKey(a => a.Id);

            builder
                .Property(a => a.Id)
                .UseIdentityColumn();

            builder
                .Property(a => a.Title)
                .IsRequired()
                .HasMaxLength(150);

            builder
                .Property(a => a.LandArea)
                .IsRequired();

            builder
                .Property(a => a.Rate)
                .IsRequired()
                .HasColumnType("money");

            builder.ToTable("Properties");
        }
    }
}
