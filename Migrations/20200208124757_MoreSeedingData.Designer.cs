﻿// <auto-generated />
using LibraryManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryManagement.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200208124757_MoreSeedingData")]
    partial class MoreSeedingData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LibraryManagement.Models.Library", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Department");

                    b.Property<string>("NameofAuthor");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Libraries");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Department = 5,
                            NameofAuthor = "James John",
                            Title = "Principles of Economics"
                        },
                        new
                        {
                            Id = 5,
                            Department = 4,
                            NameofAuthor = "Nkem Ijeoma ",
                            Title = "Drawings for Engineers"
                        },
                        new
                        {
                            Id = 6,
                            Department = 2,
                            NameofAuthor = "Egwale Francis",
                            Title = "Project Defense"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
