using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhoneBookFullStack.Domain.Core.Phones;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookFullStack.Infrastructures.DataAcess.Phones
{
    public class PhoneConfig : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.Property(c => c.PhoneNumber).HasMaxLength(20);
        }
    }
}
