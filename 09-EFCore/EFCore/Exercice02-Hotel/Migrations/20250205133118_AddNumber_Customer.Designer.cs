﻿// <auto-generated />
using System;
using Exercice02_Hotel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Exercice02_Hotel.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250205133118_AddNumber_Customer")]
    partial class AddNumber_Customer
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Exercice02_Hotel.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int?>("HotelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("HotelId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Exercice02_Hotel.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HotelId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Exercice02_Hotel.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("Exercice02_Hotel.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BookingId")
                        .HasColumnType("int");

                    b.Property<int?>("HotelId")
                        .HasColumnType("int");

                    b.Property<int>("NbBeds")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.HasIndex("HotelId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Exercice02_Hotel.Models.Booking", b =>
                {
                    b.HasOne("Exercice02_Hotel.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Exercice02_Hotel.Models.Hotel", null)
                        .WithMany("Bookings")
                        .HasForeignKey("HotelId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Exercice02_Hotel.Models.Customer", b =>
                {
                    b.HasOne("Exercice02_Hotel.Models.Hotel", null)
                        .WithMany("Customers")
                        .HasForeignKey("HotelId");
                });

            modelBuilder.Entity("Exercice02_Hotel.Models.Room", b =>
                {
                    b.HasOne("Exercice02_Hotel.Models.Booking", null)
                        .WithMany("Rooms")
                        .HasForeignKey("BookingId");

                    b.HasOne("Exercice02_Hotel.Models.Hotel", null)
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId");
                });

            modelBuilder.Entity("Exercice02_Hotel.Models.Booking", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("Exercice02_Hotel.Models.Hotel", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Customers");

                    b.Navigation("Rooms");
                });
#pragma warning restore 612, 618
        }
    }
}
