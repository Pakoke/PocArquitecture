﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PocArquitecture.Interfaces.Persistance.Entities;

namespace PocArquitecture.Persistance.Configuration
{
    public class StaffTypeConfiguration : IEntityTypeConfiguration<IStaffType>
    {
        public void Configure(EntityTypeBuilder<IStaffType> builder)
        {
            builder.ToTable("StaffType");
            builder.HasKey(c => c.StaffTypeId);
            builder.Property(c => c.NameStaff).IsRequired().HasMaxLength(45);
            builder.Property(c => c.DescriptionStaff).IsRequired().HasMaxLength(100);
        }
    }
}
