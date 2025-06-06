using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Persistence.Configuration;

public sealed class PricingConfiguration : IEntityTypeConfiguration<Pricing>
{
    public void Configure(EntityTypeBuilder<Pricing> builder)
    {
        builder.ToTable("Pricings");
        builder.Property(p => p.Name).IsRequired().HasMaxLength(100);

        builder.HasData(
               new Pricing { Id = "P001", Name = "Daily" },
               new Pricing { Id = "P002", Name = "Weekly" }
           );

    }
}
