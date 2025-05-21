using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnionArchitectureCarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    VideoUrl = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    SendDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FooterAdresses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FooterAdresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pricings",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pricings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    IconUrl = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CoverImageUrl = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Km = table.Column<int>(type: "int", nullable: false),
                    Transmission = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Seat = table.Column<byte>(type: "tinyint", nullable: false),
                    Luggage = table.Column<byte>(type: "tinyint", nullable: false),
                    CarFuelType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BigImageUrl = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    BrandId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarDescriptions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    CarId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarDescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarDescriptions_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarFeatures",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false),
                    CarId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FeatureId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarFeatures_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarFeatures_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarPricings",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CarId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PricingId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarPricings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarPricings_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarPricings_Pricings_PricingId",
                        column: x => x.PricingId,
                        principalTable: "Pricings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "Title", "UpdatedDate" },
                values: new object[] { "AB001", new DateTime(2025, 5, 21, 23, 9, 8, 855, DateTimeKind.Utc).AddTicks(8437), "Premium car rental platform with a wide selection of vehicles and 24/7 support.", "/images/about/about_us.jpg", "Welcome to CarBook", new DateTime(2025, 5, 21, 23, 9, 8, 855, DateTimeKind.Utc).AddTicks(8439) });

            migrationBuilder.InsertData(
                table: "Banners",
                columns: new[] { "Id", "CreatedDate", "Description", "Title", "UpdatedDate", "VideoUrl" },
                values: new object[] { "BN001", new DateTime(2025, 5, 21, 23, 9, 8, 856, DateTimeKind.Utc).AddTicks(192), "Browse 100+ cars, instant booking, hassle‑free pickup!", "Find Your Perfect Ride", new DateTime(2025, 5, 21, 23, 9, 8, 856, DateTimeKind.Utc).AddTicks(193), "/videos/banner.mp4" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { "B001", new DateTime(2025, 5, 21, 23, 9, 8, 856, DateTimeKind.Utc).AddTicks(2808), "Audi", new DateTime(2025, 5, 21, 23, 9, 8, 856, DateTimeKind.Utc).AddTicks(2808) },
                    { "B002", new DateTime(2025, 5, 21, 23, 9, 8, 856, DateTimeKind.Utc).AddTicks(2825), "BMW", new DateTime(2025, 5, 21, 23, 9, 8, 856, DateTimeKind.Utc).AddTicks(2825) }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { "C001", new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(3562), "Sedan", new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(3562) },
                    { "C002", new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(3580), "SUV", new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(3580) }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "CreatedDate", "Email", "Message", "Name", "SendDate", "Subject", "UpdatedDate" },
                values: new object[] { "CT001", new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(6045), "demo@carbook.com", "How much would it cost to rent an Audi A4 for a week?", "Demo User", new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sample inquiry", new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(6045) });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { "F001", new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(8530), "Air Conditioning", new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(8531) },
                    { "F002", new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(8552), "Bluetooth", new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(8553) }
                });

            migrationBuilder.InsertData(
                table: "FooterAdresses",
                columns: new[] { "Id", "Adress", "CreatedDate", "Description", "Email", "Phone", "UpdatedDate" },
                values: new object[] { "FA001", "Istanbul, Maslak 1453 No:12", new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(1020), "Head Office", "info@carbook.com", "+90 212 555 55 55", new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(1021) });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { "L001", new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(2772), "Istanbul", new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(2773) },
                    { "L002", new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(2786), "Ankara", new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(2786) }
                });

            migrationBuilder.InsertData(
                table: "Pricings",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { "P001", new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(4157), "Daily", new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(4157) },
                    { "P002", new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(4170), "Weekly", new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(4171) }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CreatedDate", "Description", "IconUrl", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { "S001", new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(6463), "We’ve got your back on every kilometer.", "/icons/assistance.svg", "24/7 Roadside Assistance", new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(6463) },
                    { "S002", new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(6484), "Drive safe – all rentals include comprehensive coverage.", "/icons/insurance.svg", "Full Insurance", new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(6485) }
                });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "CreatedDate", "Icon", "Name", "UpdatedDate", "Url" },
                values: new object[,]
                {
                    { "SM001", new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(8384), "fa-instagram", "Instagram", new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(8385), "https://instagram.com/carbook" },
                    { "SM002", new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(8400), "fa-twitter", "Twitter", new DateTime(2025, 5, 21, 23, 9, 8, 859, DateTimeKind.Utc).AddTicks(8400), "https://x.com/carbook" }
                });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "Comment", "CreatedDate", "ImageUrl", "Name", "Title", "UpdatedDate" },
                values: new object[] { "TST001", "Smooth booking process and very clean cars. Highly recommend!", new DateTime(2025, 5, 21, 23, 9, 8, 860, DateTimeKind.Utc).AddTicks(904), "/images/testimonials/john.jpg", "John Doe", "Frequent Traveler", new DateTime(2025, 5, 21, 23, 9, 8, 860, DateTimeKind.Utc).AddTicks(904) });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "BigImageUrl", "BrandId", "CarFuelType", "CoverImageUrl", "CreatedDate", "Km", "Luggage", "Model", "Seat", "Transmission", "UpdatedDate" },
                values: new object[] { "CAR001", "/images/cars/audi-a4-big.jpg", "B001", "Petrol", "/images/cars/audi-a4-cover.jpg", new DateTime(2025, 5, 21, 23, 9, 8, 856, DateTimeKind.Utc).AddTicks(8250), 25000, (byte)4, "A4", (byte)5, "Automatic", new DateTime(2025, 5, 21, 23, 9, 8, 856, DateTimeKind.Utc).AddTicks(8251) });

            migrationBuilder.InsertData(
                table: "CarDescriptions",
                columns: new[] { "Id", "CarId", "CreatedDate", "Details", "UpdatedDate" },
                values: new object[] { "CD001", "CAR001", new DateTime(2025, 5, 21, 23, 9, 8, 857, DateTimeKind.Utc).AddTicks(226), "Comfortable compact executive sedan with modern infotainment and safety features.", new DateTime(2025, 5, 21, 23, 9, 8, 857, DateTimeKind.Utc).AddTicks(227) });

            migrationBuilder.InsertData(
                table: "CarFeatures",
                columns: new[] { "Id", "Available", "CarId", "CreatedDate", "FeatureId", "UpdatedDate" },
                values: new object[,]
                {
                    { "CF001", true, "CAR001", new DateTime(2025, 5, 21, 23, 9, 8, 857, DateTimeKind.Utc).AddTicks(5111), "F001", new DateTime(2025, 5, 21, 23, 9, 8, 857, DateTimeKind.Utc).AddTicks(5112) },
                    { "CF002", true, "CAR001", new DateTime(2025, 5, 21, 23, 9, 8, 857, DateTimeKind.Utc).AddTicks(5130), "F002", new DateTime(2025, 5, 21, 23, 9, 8, 857, DateTimeKind.Utc).AddTicks(5130) }
                });

            migrationBuilder.InsertData(
                table: "CarPricings",
                columns: new[] { "Id", "Amount", "CarId", "CreatedDate", "PricingId", "UpdatedDate" },
                values: new object[,]
                {
                    { "CP001", 95.00m, "CAR001", new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(1019), "P001", new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(1019) },
                    { "CP002", 550.00m, "CAR001", new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(1043), "P002", new DateTime(2025, 5, 21, 23, 9, 8, 858, DateTimeKind.Utc).AddTicks(1043) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarDescriptions_CarId",
                table: "CarDescriptions",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CarFeatures_CarId_FeatureId",
                table: "CarFeatures",
                columns: new[] { "CarId", "FeatureId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarFeatures_FeatureId",
                table: "CarFeatures",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_CarPricings_CarId",
                table: "CarPricings",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_CarPricings_PricingId",
                table: "CarPricings",
                column: "PricingId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BrandId",
                table: "Cars",
                column: "BrandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "CarDescriptions");

            migrationBuilder.DropTable(
                name: "CarFeatures");

            migrationBuilder.DropTable(
                name: "CarPricings");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "FooterAdresses");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Pricings");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
