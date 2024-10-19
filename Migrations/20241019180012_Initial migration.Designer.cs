﻿// <auto-generated />
using System;
using ContactManager.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContactManager.Migrations
{
    [DbContext(typeof(ContactManagerContext))]
    [Migration("20241019180012_Initial migration")]
    partial class Initialmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ContactManager.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Friend"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Family"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Work"
                        });
                });

            modelBuilder.Entity("ContactManager.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateAdded = new DateTime(2024, 10, 19, 18, 0, 12, 550, DateTimeKind.Utc).AddTicks(3318),
                            Email = "john.doe@domain.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Phone = "111-111-1111"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            DateAdded = new DateTime(2024, 10, 19, 18, 0, 12, 550, DateTimeKind.Utc).AddTicks(3326),
                            Email = "william.smith@domain.com",
                            FirstName = "William",
                            LastName = "Smith",
                            Phone = "222-222-2222"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            DateAdded = new DateTime(2024, 10, 19, 18, 0, 12, 550, DateTimeKind.Utc).AddTicks(3327),
                            Email = "ashley.rock@domain.com",
                            FirstName = "Ashley",
                            LastName = "Rock",
                            Phone = "333-333-3333"
                        });
                });

            modelBuilder.Entity("ContactManager.Models.Contact", b =>
                {
                    b.HasOne("ContactManager.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
