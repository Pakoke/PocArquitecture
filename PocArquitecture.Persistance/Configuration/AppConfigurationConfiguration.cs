using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PocArquitecture.Persistance.Entities;

namespace PocArquitecture.Persistance.Configuration
{
    public class AppConfigurationConfiguration : IEntityTypeConfiguration<AppConfigurationDto>
    {
        public void Configure(EntityTypeBuilder<AppConfigurationDto> builder)
        {
            builder.ToTable("AppConfiguration");
            builder.HasKey(c => c.AppConfigurationId);
            builder.Property(c => c.Name).IsRequired().HasMaxLength(45);
            builder.Property(c => c.Value).IsRequired().HasMaxLength(1000);
            builder.Property(c => c.Description).IsRequired().HasMaxLength(200);

        }
    }
}
