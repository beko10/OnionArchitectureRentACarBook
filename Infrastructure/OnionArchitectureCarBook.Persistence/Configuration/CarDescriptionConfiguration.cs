using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitectureCarBook.Domain.Entities;

namespace OnionArchitectureCarBook.Persistence.Configurations;

public sealed class CarDescriptionConfiguration : IEntityTypeConfiguration<CarDescription>
{
    public void Configure(EntityTypeBuilder<CarDescription> builder)
    {
        builder.ToTable("CarDescriptions");
        builder.Property(p => p.Details).IsRequired().HasMaxLength(1000);

        builder.HasOne(p => p.Car)
               .WithMany(c => c.CarDescriptions)
               .HasForeignKey(p => p.CarId);

        builder.HasData(
                new CarDescription
                {
                    Id = "CD001",
                    CarId = "CAR001",
                    Details = "Comfortable compact executive sedan with modern infotainment and safety features."
                }
            );
    }
}
