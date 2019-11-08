using System;
using System.Collections.Generic;
using System.Text;
using Microsoft;
using Microsoft.EntityFrameworkCore;
using PhoneBookFullStack.Domain.Core.People;
using PhoneBookFullStack.Domain.Core.Phones;
using PhoneBookFullStack.Domain.Core.Tags;
using PhoneBookFullStack.Infrastructures.DataAcess.People;
using PhoneBookFullStack.Infrastructures.DataAcess.Phones;
using PhoneBookFullStack.Infrastructures.DataAcess.Tags;

namespace PhoneBookFullStack.Infrastructures.DataAcess.Common
{
    public class PhoneBookContext:DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<PersonTag> PersonTags { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonConfig());
            modelBuilder.ApplyConfiguration(new PersonTagConfig());
            modelBuilder.ApplyConfiguration(new TagConfig());
            modelBuilder.ApplyConfiguration(new PhoneConfig());  
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
