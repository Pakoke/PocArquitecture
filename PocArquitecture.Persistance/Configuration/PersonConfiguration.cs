using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PocArquitecture.Interfaces.Persistance.Entities;

namespace PocArquitecture.Persistance.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<IPersonDto>
    {
        public void Configure(EntityTypeBuilder<IPersonDto> builder)
        {
            builder.ToTable("Person");
            builder.HasKey(c => c.Dni);
            builder.Property(c => c.BirthDate).IsRequired().HasMaxLength(45);
            builder.Property(c => c.FamilyName).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Gender).IsRequired().HasMaxLength(10);
            builder.Property(c => c.GiveName).IsRequired().HasMaxLength(50);
            builder.Property(c => c.HomeAdress).IsRequired().HasMaxLength(50);
            builder.Property(c => c.MiddleName).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Phone).IsRequired().HasMaxLength(15);
            builder.Property(c => c.MiddleName).IsRequired().HasMaxLength(200);
            builder.Property(c => c.Title).IsRequired().HasMaxLength(200);

        }
    }
}
