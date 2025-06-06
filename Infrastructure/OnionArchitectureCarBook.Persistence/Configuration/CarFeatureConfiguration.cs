using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Persistence.Configuration;

public sealed class CarFeatureConfiguration : IEntityTypeConfiguration<CarFeature>
{
    public void Configure(EntityTypeBuilder<CarFeature> builder)
    {
        builder.ToTable("CarFeatures");

        builder.HasIndex(p => new { p.CarId, p.FeatureId }).IsUnique();

        builder.HasOne(p => p.Car)
               .WithMany(c => c.CarFeatures)
               .HasForeignKey(p => p.CarId);

        builder.HasOne(p => p.Feature)
               .WithMany(f => f.CarFeatures)
               .HasForeignKey(p => p.FeatureId);

        builder.HasData(
                new CarFeature { Id = "CF001", CarId = "CAR001", FeatureId = "F001", Available = true },
                new CarFeature { Id = "CF002", CarId = "CAR001", FeatureId = "F002", Available = true }
            );

    }
}
