using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitectureCarBook.Domain.Entities;

namespace OnionArchitectureCarBook.Persistence.Configurations;

public sealed class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.ToTable("Cars");

        builder.Property(p => p.Model).IsRequired().HasMaxLength(100);
        builder.Property(p => p.CoverImageUrl).HasMaxLength(300);
        builder.Property(p => p.BigImageUrl).HasMaxLength(300);
        builder.Property(p => p.Transmission).HasMaxLength(50);
        builder.Property(p => p.CarFuelType).HasMaxLength(50);

        builder.HasOne(p => p.Brand)
               .WithMany(b => b.Cars)
               .HasForeignKey(p => p.BrandId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(p => p.CarFeatures)
               .WithOne(cf => cf.Car)
               .HasForeignKey(cf => cf.CarId);

        builder.HasMany(p => p.CarDescriptions)
               .WithOne(cd => cd.Car)
               .HasForeignKey(cd => cd.CarId);

        builder.HasMany(p => p.CarPricings)
               .WithOne(cp => cp.Car)
               .HasForeignKey(cp => cp.CarId);
    }
}
