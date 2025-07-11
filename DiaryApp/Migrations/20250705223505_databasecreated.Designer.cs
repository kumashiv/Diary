﻿// <auto-generated />
using System;
using DiaryApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiaryApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250705223505_databasecreated")]
    partial class databasecreated
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DiaryApp.Models.DiaryEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DiaryEntries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Went hiking with Joe!",
                            Created = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Went Hiking"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Went shopping with Joe!",
                            Created = new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Went Shopping"
                        },
                        new
                        {
                            Id = 3,
                            Content = "Went diving with Joe!",
                            Created = new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Went Diving"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
