using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContactManager.Models;

namespace ContactManager.Data
{
    public class ContactManagerContext : DbContext
    {
        public ContactManagerContext (DbContextOptions<ContactManagerContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; } = default!;
        public DbSet<Category> Categories { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Create default categories when creating the model
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Friend" },
                new Category { Id = 2, Name = "Family" },
                new Category { Id = 3, Name = "Work" }
            );

            // Create default contacts when creating the model
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Phone = "111-111-1111",
                    Email = "john.doe@domain.com",
                    CategoryId = 1
                },
                new Contact
                {
                    Id = 2,
                    FirstName = "William",
                    LastName = "Smith",
                    Phone = "222-222-2222",
                    Email = "william.smith@domain.com",
                    CategoryId = 2
                },
                new Contact
                {
                    Id = 3,
                    FirstName = "Ashley",
                    LastName = "Rock",
                    Phone = "333-333-3333",
                    Email = "ashley.rock@domain.com",
                    CategoryId = 3
                }
            );
        }
    }
}
