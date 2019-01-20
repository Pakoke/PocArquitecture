using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PocArquitecture.Interfaces.Persistance.Entities;

namespace PocArquitecture.Persistance.Configuration
{
    public class HospitalConfiguration : IEntityTypeConfiguration<IHospital>
    {
        public void Configure(EntityTypeBuilder<IHospital> builder)
        {
            builder.ToTable("Hospital");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(45);
            builder.Property(c => c.Address).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Phone).IsRequired().HasMaxLength(14);


        }
    }
}
