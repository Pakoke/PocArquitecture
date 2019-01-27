using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PocArquitecture.Persistance.Entities;

namespace PocArquitecture.Persistance.Configuration
{
    public class HospitalConfiguration : IEntityTypeConfiguration<Hospital>
    {
        public void Configure(EntityTypeBuilder<Hospital> builder)
        {
            builder.ToTable("Hospital");
            builder.HasKey(c => c.HospitalId);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(45);
            builder.Property(c => c.Address).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Phone).IsRequired().HasMaxLength(14);


        }
    }
}
