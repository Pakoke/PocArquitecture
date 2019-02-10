using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PocArquitecture.Persistance.Entities;

namespace PocArquitecture.Persistance.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<PersonDto>
    {
        public void Configure(EntityTypeBuilder<PersonDto> builder)
        {
            builder.ToTable("Person");
            builder.HasKey(c => c.Dni);
            builder.Property(c => c.BirthDate).HasMaxLength(45);
            builder.Property(c => c.FamilyName).HasMaxLength(100);
            builder.Property(c => c.Gender).IsRequired().HasMaxLength(10);
            builder.Property(c => c.GivenName).HasMaxLength(50);
            builder.Property(c => c.HomeAdress).HasMaxLength(50);
            builder.Property(c => c.MiddleName).HasMaxLength(50);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Phone).HasMaxLength(15);
            builder.Property(c => c.Title).HasMaxLength(200);

        }
    }
}
