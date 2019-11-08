using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhoneBookFullStack.Domain.Core.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookFullStack.Infrastructures.DataAcess.People
{
    public class PersonTagConfig : IEntityTypeConfiguration<PersonTag>
    {
        public void Configure(EntityTypeBuilder<PersonTag> builder)
        {
            
        }
    }
}
