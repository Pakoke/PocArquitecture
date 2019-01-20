using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PocArquitecture.Interfaces.Persistance.Entities;

namespace PocArquitecture.Persistance.Configuration
{
    public class AppConfigurationConfiguration : IEntityTypeConfiguration<IAppConfiguration>
    {
        public void Configure(EntityTypeBuilder<IAppConfiguration> builder)
        {
            builder.ToTable("AppConfiguration");
            builder.HasKey(c => c.ConfigurationId);
            builder.Property(c => c.ConfigurationId).ValueGeneratedOnAdd().IsRequired();
            builder.Property(c => c.Name).IsRequired().HasMaxLength(45);
            builder.Property(c => c.Value).IsRequired().HasMaxLength(1000);
            builder.Property(c => c.Description).IsRequired().HasMaxLength(200);

        }
    }
}
