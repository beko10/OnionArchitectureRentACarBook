﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnionArchitectureRentACarBook.Persistence.Context;

#nullable disable

namespace OnionArchitectureCarBook.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250521230910_Mig1")]
    partial class Mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OnionArchitectureCarBook.Domain.Entities.About", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Abouts", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "AB001",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 855, DateTimeKind.Utc).AddTicks(8437),
                            Description = "Premium car rental platform with a wide selection of vehicles and 24/7 support.",
                            ImageUrl = "/images/about/about_us.jpg",
                            Title = "Welcome to CarBook",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 855, DateTimeKind.Utc).AddTicks(8439)
                        });
                });

            modelBuilder.Entity("OnionArchitectureCarBook.Domain.Entities.Banner", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("VideoUrl")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("Banners", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "BN001",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 856, DateTimeKind.Utc).AddTicks(192),
                            Description = "Browse 100+ cars, instant booking, hassle‑free pickup!",
                            Title = "Find Your Perfect Ride",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 856, DateTimeKind.Utc).AddTicks(193),
                            VideoUrl = "/videos/banner.mp4"
                        });
                });

            modelBuilder.Entity("OnionArchitectureCarBook.Domain.Entities.Brand", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Brands", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "B001",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 856, DateTimeKind.Utc).AddTicks(2808),
                            Name = "Audi",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 856, DateTimeKind.Utc).AddTicks(2808)
                        },
                        new
                        {
                            Id = "B002",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 856, DateTimeKind.Utc).AddTicks(2825),
                            Name = "BMW",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 856, DateTimeKind.Utc).AddTicks(2825)
                        });
                });

            modelBuilder.Entity("OnionArchitectureCarBook.Domain.Entities.Car", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BigImageUrl")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("BrandId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CarFuelType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CoverImageUrl")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Km")
                        .HasColumnType("int");

                    b.Property<byte>("Luggage")
                        .HasColumnType("tinyint");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte>("Seat")
                        .HasColumnType("tinyint");

                    b.Property<string>("Transmission")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Cars", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "CAR001",
                            BigImageUrl = "/images/cars/audi-a4-big.jpg",
                            BrandId = "B001",
                            CarFuelType = "Petrol",
                            CoverImageUrl = "/images/cars/audi-a4-cover.jpg",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 856, DateTimeKind.Utc).AddTicks(8250),
                            Km = 25000,
                            Luggage = (byte)4,
                            Model = "A4",
                            Seat = (byte)5,
                            Transmission = "Automatic",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 856, DateTimeKind.Utc).AddTicks(8251)
                        });
                });

            modelBuilder.Entity("OnionArchitectureCarBook.Domain.Entities.CarDescription", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CarId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("CarDescriptions", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "CD001",
                            CarId = "CAR001",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 857, DateTimeKind.Utc).AddTicks(226),
                            Details = "Comfortable compact executive sedan with modern infotainment and safety features.",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 857, DateTimeKind.Utc).AddTicks(227)
                        });
                });

            modelBuilder.Entity("OnionArchitectureCarBook.Domain.Entities.CarFeature", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<string>("CarId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FeatureId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FeatureId");

                    b.HasIndex("CarId", "FeatureId")
                        .IsUnique();

                    b.ToTable("CarFeatures", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "CF001",
                            Available = true,
                            CarId = "CAR001",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 857, DateTimeKind.Utc).AddTicks(5111),
                            FeatureId = "F001",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 857, DateTimeKind.Utc).AddTicks(5112)
                        },
                        new
                        {
                            Id = "CF002",
                            Available = true,
                            CarId = "CAR001",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 857, DateTimeKind.Utc).AddTicks(5130),
                            FeatureId = "F002",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 857, DateTimeKind.Utc).AddTicks(5130)
                        });
                });

            modelBuilder.Entity("OnionArchitectureCarBook.Domain.Entities.CarPricing", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CarId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PricingId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("PricingId");

                    b.ToTable("CarPricings", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "CP001",
                            Amount = 95.00m,
                            CarId = "CAR001",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(1019),
                            PricingId = "P001",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(1019)
                        },
                        new
                        {
                            Id = "CP002",
                            Amount = 550.00m,
                            CarId = "CAR001",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(1043),
                            PricingId = "P002",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(1043)
                        });
                });

            modelBuilder.Entity("OnionArchitectureCarBook.Domain.Entities.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "C001",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(3562),
                            Name = "Sedan",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(3562)
                        },
                        new
                        {
                            Id = "C002",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(3580),
                            Name = "SUV",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(3580)
                        });
                });

            modelBuilder.Entity("OnionArchitectureCarBook.Domain.Entities.Contact", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("SendDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Contacts", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "CT001",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(6045),
                            Email = "demo@carbook.com",
                            Message = "How much would it cost to rent an Audi A4 for a week?",
                            Name = "Demo User",
                            SendDate = new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Subject = "Sample inquiry",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(6045)
                        });
                });

            modelBuilder.Entity("OnionArchitectureCarBook.Domain.Entities.Feature", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Features", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "F001",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(8530),
                            Name = "Air Conditioning",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(8531)
                        },
                        new
                        {
                            Id = "F002",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(8552),
                            Name = "Bluetooth",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(8553)
                        });
                });

            modelBuilder.Entity("OnionArchitectureCarBook.Domain.Entities.FooterAdress", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("FooterAdresses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "FA001",
                            Adress = "Istanbul, Maslak 1453 No:12",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(1020),
                            Description = "Head Office",
                            Email = "info@carbook.com",
                            Phone = "+90 212 555 55 55",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(1021)
                        });
                });

            modelBuilder.Entity("OnionArchitectureCarBook.Domain.Entities.Location", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Locations", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "L001",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(2772),
                            Name = "Istanbul",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(2773)
                        },
                        new
                        {
                            Id = "L002",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(2786),
                            Name = "Ankara",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(2786)
                        });
                });

            modelBuilder.Entity("OnionArchitectureCarBook.Domain.Entities.Pricing", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Pricings", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "P001",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(4157),
                            Name = "Daily",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(4157)
                        },
                        new
                        {
                            Id = "P002",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(4170),
                            Name = "Weekly",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(4171)
                        });
                });

            modelBuilder.Entity("OnionArchitectureCarBook.Domain.Entities.Service", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("IconUrl")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Services", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "S001",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(6463),
                            Description = "We’ve got your back on every kilometer.",
                            IconUrl = "/icons/assistance.svg",
                            Title = "24/7 Roadside Assistance",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(6463)
                        },
                        new
                        {
                            Id = "S002",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(6484),
                            Description = "Drive safe – all rentals include comprehensive coverage.",
                            IconUrl = "/icons/insurance.svg",
                            Title = "Full Insurance",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(6485)
                        });
                });

            modelBuilder.Entity("OnionArchitectureCarBook.Domain.Entities.SocialMedia", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("SocialMedias", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "SM001",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(8384),
                            Icon = "fa-instagram",
                            Name = "Instagram",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(8385),
                            Url = "https://instagram.com/carbook"
                        },
                        new
                        {
                            Id = "SM002",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(8400),
                            Icon = "fa-twitter",
                            Name = "Twitter",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(8400),
                            Url = "https://x.com/carbook"
                        });
                });

            modelBuilder.Entity("OnionArchitectureCarBook.Domain.Entities.Testimonial", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Testimonials", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "TST001",
                            Comment = "Smooth booking process and very clean cars. Highly recommend!",
                            CreatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 860, DateTimeKind.Utc).AddTicks(904),
                            ImageUrl = "/images/testimonials/john.jpg",
                            Name = "John Doe",
                            Title = "Frequent Traveler",
                            UpdatedDate = new DateTime(2025, 5, 21, 23, 9, 8, 860, DateTimeKind.Utc).AddTicks(904)
                        });
                });

            modelBuilder.Entity("OnionArchitectureCarBook.Domain.Entities.Car", b =>
                {
                    b.HasOne("OnionArchitectureCarBook.Domain.Entities.Brand", "Brand")
                        .WithMany("Cars")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("OnionArchitectureCarBook.Domain.Entities.CarDescription", b =>
                {
                    b.HasOne("OnionArchitectureCarBook.Domain.Entities.Car", "Car")
                        .WithMany("CarDescriptions")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("OnionArchitectureCarBook.Domain.Entities.CarFeature", b =>
                {
                    b.HasOne("OnionArchitectureCarBook.Domain.Entities.Car", "Car")
                        .WithMany("CarFeatures")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnionArchitectureCarBook.Domain.Entities.Feature", "Feature")
                        .WithMany("CarFeatures")
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Feature");
                });

            modelBuilder.Entity("OnionArchitectureCarBook.Domain.Entities.CarPricing", b =>
                {
                    b.HasOne("OnionArchitectureCarBook.Domain.Entities.Car", "Car")
                        .WithMany("CarPricings")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnionArchitectureCarBook.Domain.Entities.Pricing", "Pricing")
                        .WithMany("CarPricings")
                        .HasForeignKey("PricingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Pricing");
                });

            modelBuilder.Entity("OnionArchitectureCarBook.Domain.Entities.Brand", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("OnionArchitectureCarBook.Domain.Entities.Car", b =>
                {
                    b.Navigation("CarDescriptions");

                    b.Navigation("CarFeatures");

                    b.Navigation("CarPricings");
                });

            modelBuilder.Entity("OnionArchitectureCarBook.Domain.Entities.Feature", b =>
                {
                    b.Navigation("CarFeatures");
                });

            modelBuilder.Entity("OnionArchitectureCarBook.Domain.Entities.Pricing", b =>
                {
                    b.Navigation("CarPricings");
                });
#pragma warning restore 612, 618
        }
    }
}
