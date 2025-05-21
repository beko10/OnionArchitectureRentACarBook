using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitectureCarBook.Domain.Entities;

namespace OnionArchitectureCarBook.Persistence.Configurations;

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
    }
}
