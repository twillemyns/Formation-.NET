﻿// <auto-generated />
using System;
using Exercice06.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Exercice06.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250213135423_AddData")]
    partial class AddData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Exercice06.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsWatched")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateOnly>("ReleaseDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsWatched = true,
                            Name = "The Shawshank Redemption",
                            ReleaseDate = new DateOnly(1994, 10, 14)
                        },
                        new
                        {
                            Id = 2,
                            IsWatched = true,
                            Name = "The Godfather",
                            ReleaseDate = new DateOnly(1972, 3, 24)
                        },
                        new
                        {
                            Id = 3,
                            IsWatched = true,
                            Name = "The Dark Knight",
                            ReleaseDate = new DateOnly(2008, 7, 18)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
