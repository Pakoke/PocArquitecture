using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PocArquitecture.Interfaces.Persistance.Entities;
using System;

namespace PocArquitecture.Persistance.Configuration
{
    public class StaffConfiguration : IEntityTypeConfiguration<IStaff>
    {
        public void Configure(EntityTypeBuilder<IStaff> builder)
        {
            throw new NotImplementedException();
        }
    }
}
