using Microsoft.EntityFrameworkCore;
using PhoneBookFullStack.Domain.Core.Tags;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookFullStack.Infrastructures.DataAcess.Tags
{
    public class TagConfig : IEntityTypeConfiguration<Tag>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Tag> builder)
        {
            builder.Property(c => c.Title).HasMaxLength(50);
        }
    }
}
