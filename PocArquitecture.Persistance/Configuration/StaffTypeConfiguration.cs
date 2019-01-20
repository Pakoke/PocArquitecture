using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PocArquitecture.Interfaces.Persistance.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PocArquitecture.Persistance.Configuration
{
    public class StaffTypeConfiguration : IEntityTypeConfiguration<IStaffType>
    {
        public void Configure(EntityTypeBuilder<IStaffType> builder)
        {
            throw new NotImplementedException();
        }
    }
}
