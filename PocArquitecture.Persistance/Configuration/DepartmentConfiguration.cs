using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PocArquitecture.Interfaces.Persistance.Entities;

namespace PocArquitecture.Persistance.Configuration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<IDepartment>
    {
        public void Configure(EntityTypeBuilder<IDepartment> builder)
        {
            builder.ToTable("Department");
            builder.HasKey(c => new { c.DeparmentId, c.HostpitalId });
            builder.Property(c => c.TypeOfDepartment).IsRequired().HasMaxLength(45);

        }
    }
}
