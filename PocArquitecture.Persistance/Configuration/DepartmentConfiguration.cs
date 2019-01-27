using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PocArquitecture.Persistance.Entities;

namespace PocArquitecture.Persistance.Configuration
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Department");
            builder.HasKey(c => new { c.DeparmentId, c.HostpitalId });
            builder.Property(c => c.TypeOfDepartment).IsRequired().HasMaxLength(45);

        }
    }
}
