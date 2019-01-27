using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PocArquitecture.Interfaces.Persistance.Entities;

namespace PocArquitecture.Persistance.Configuration
{
    public class PatientConfiguration : IEntityTypeConfiguration<IPatientDto>
    {
        public void Configure(EntityTypeBuilder<IPatientDto> builder)
        {
            builder.ToTable("Patient");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.AcceptedDate).IsRequired().HasMaxLength(45);
            builder.Property(c => c.Age).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Sickness).IsRequired().HasMaxLength(30);
            builder.Property(c => c.History).HasMaxLength(200);
            builder.Property(c => c.SpecialRequirements).HasMaxLength(200);
            builder.Property(c => c.Allergies).HasMaxLength(200);

        }
    }
}
