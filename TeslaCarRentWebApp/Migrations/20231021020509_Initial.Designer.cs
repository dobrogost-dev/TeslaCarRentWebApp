﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeslaCarRentWebApp.Models;

#nullable disable

namespace TeslaCarRentWebApp.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20231021020509_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TeslaCarRentWebApp.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfSeats")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Car");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Model = "Tesla S",
                            NumberOfSeats = 5,
                            Price = 120m
                        },
                        new
                        {
                            Id = 2,
                            Model = "Tesla 3",
                            NumberOfSeats = 5,
                            Price = 150m
                        },
                        new
                        {
                            Id = 3,
                            Model = "Tesla X",
                            NumberOfSeats = 5,
                            Price = 140m
                        },
                        new
                        {
                            Id = 4,
                            Model = "Tesla Y",
                            NumberOfSeats = 5,
                            Price = 200m
                        });
                });

            modelBuilder.Entity("TeslaCarRentWebApp.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DropOffDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("FinalPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime>("PickUpDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("Order");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarId = 1,
                            DropOffDate = new DateTime(2023, 10, 21, 4, 5, 9, 696, DateTimeKind.Local).AddTicks(6902),
                            FinalPrice = 0m,
                            PickUpDate = new DateTime(2023, 10, 21, 4, 5, 9, 696, DateTimeKind.Local).AddTicks(6843)
                        });
                });

            modelBuilder.Entity("TeslaCarRentWebApp.Models.Order", b =>
                {
                    b.HasOne("TeslaCarRentWebApp.Models.Car", "OrderedCar")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderedCar");
                });
#pragma warning restore 612, 618
        }
    }
}
