using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitectureCarBook.Domain.Entities;

namespace OnionArchitectureCarBook.Persistence.Configurations;

public sealed class FeatureConfiguration : IEntityTypeConfiguration<Feature>
{
    public void Configure(EntityTypeBuilder<Feature> builder)
    {
        builder.ToTable("Features");
        builder.Property(p => p.Name).IsRequired().HasMaxLength(100);

        builder.HasData(
                new Feature { Id = "F001", Name = "Air Conditioning" },
                new Feature { Id = "F002", Name = "Bluetooth" }
            );

    }
}
