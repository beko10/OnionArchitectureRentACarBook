using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Persistence.Configuration;

public sealed class LocationConfiguration : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> builder)
    {
        builder.ToTable("Locations");
        builder.Property(p => p.Name).IsRequired().HasMaxLength(100);

        builder.HasData(
                new Location { Id = "L001", Name = "Istanbul" },
                new Location { Id = "L002", Name = "Ankara" }
            );

    }
}
