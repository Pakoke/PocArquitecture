using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PocArquitecture.Persistance.Entities;

namespace PocArquitecture.Persistance.Configuration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<DepartmentDto>
    {
        public void Configure(EntityTypeBuilder<DepartmentDto> builder)
        {
            builder.ToTable("Department");
            builder.HasKey(c => new { c.DepartmentId });
            builder.Property(c => c.TypeOfDepartment).IsRequired().HasMaxLength(45);
            builder.Property(c => c.HospitalId).IsRequired();
            builder.Property(c => c.Code).HasMaxLength(15);
            builder.Property(c => c.Name).HasMaxLength(45);

        }
    }
}
