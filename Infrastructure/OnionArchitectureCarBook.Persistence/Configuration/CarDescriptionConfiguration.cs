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
    }
}
