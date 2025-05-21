using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitectureCarBook.Domain.Entities;

namespace OnionArchitectureCarBook.Persistence.Configurations;

public sealed class PricingConfiguration : IEntityTypeConfiguration<Pricing>
{
    public void Configure(EntityTypeBuilder<Pricing> builder)
    {
        builder.ToTable("Pricings");
        builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
    }
}
