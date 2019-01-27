using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PocArquitecture.Persistance.Entities;

namespace PocArquitecture.Persistance.Configuration
{
    public class StaffTypeConfiguration : IEntityTypeConfiguration<StaffType>
    {
        public void Configure(EntityTypeBuilder<StaffType> builder)
        {
            builder.ToTable("StaffType");
            builder.HasKey(c => c.StaffTypeId);
            builder.Property(c => c.NameStaff).IsRequired().HasMaxLength(45);
            builder.Property(c => c.DescriptionStaff).IsRequired().HasMaxLength(100);
        }
    }
}
