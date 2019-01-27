﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PocArquitecture.Interfaces.Persistance.Entities;

namespace PocArquitecture.Persistance.Configuration
{
    public class StaffConfiguration : IEntityTypeConfiguration<IStaff>
    {
        public void Configure(EntityTypeBuilder<IStaff> builder)
        {
            builder.ToTable("Staff");
            builder.HasKey(c => c.StaffId);
            builder.Property(c => c.Certification).IsRequired().HasMaxLength(45);
            builder.Property(c => c.DeparmentId).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Education).IsRequired().HasMaxLength(10);
            builder.Property(c => c.Joined).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Languages).IsRequired().HasMaxLength(50);

        }
    }
}