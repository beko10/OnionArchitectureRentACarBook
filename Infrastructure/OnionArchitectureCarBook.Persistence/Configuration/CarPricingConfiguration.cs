using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Persistence.Configuration;

public sealed class CarPricingConfiguration : IEntityTypeConfiguration<CarPricing>
{
    public void Configure(EntityTypeBuilder<CarPricing> builder)
    {
        builder.ToTable("CarPricings");

        builder.Property(p => p.Amount)
               .HasColumnType("decimal(18,2)")
               .IsRequired();

        builder.HasOne(p => p.Car)
               .WithMany(c => c.CarPricings)
               .HasForeignKey(p => p.CarId);

        builder.HasOne(p => p.Pricing)
               .WithMany(pr => pr.CarPricings)
               .HasForeignKey(p => p.PricingId);

        builder.HasData(
               new CarPricing { Id = "CP001", CarId = "CAR001", PricingId = "P001", Amount = 95.00m },
               new CarPricing { Id = "CP002", CarId = "CAR001", PricingId = "P002", Amount = 550.00m }
           );

    }
}
