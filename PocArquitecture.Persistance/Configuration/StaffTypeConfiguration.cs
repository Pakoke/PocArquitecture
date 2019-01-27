using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PocArquitecture.Persistance.Entities;

namespace PocArquitecture.Persistance.Configuration
{
    public class StaffTypeConfiguration : IEntityTypeConfiguration<StaffTypeDto>
    {
        public void Configure(EntityTypeBuilder<StaffTypeDto> builder)
        {
            builder.ToTable("StaffType");
            builder.HasKey(c => c.StaffTypeId);
            builder.Property(c => c.NameStaff).IsRequired().HasMaxLength(45);
            builder.Property(c => c.DescriptionStaff).IsRequired().HasMaxLength(100);
        }
    }
}
