using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitectureCarBook.Domain.Entities;

namespace OnionArchitectureCarBook.Persistence.Configurations;

public sealed class LocationConfiguration : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> builder)
    {
        builder.ToTable("Locations");
        builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
    }
}
