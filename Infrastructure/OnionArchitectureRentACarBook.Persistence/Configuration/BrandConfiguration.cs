using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Persistence.Configuration;

public sealed class BrandConfiguration : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.ToTable("Brands");

        builder.Property(p => p.Name).IsRequired().HasMaxLength(100);

        builder.HasMany(p => p.Cars)
               .WithOne(c => c.Brand)
               .HasForeignKey(c => c.BrandId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasData(
                new Brand { Id = "B001", Name = "Audi" },
                new Brand { Id = "B002", Name = "BMW" }
            );

    }
}
