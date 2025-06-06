using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Persistence.Configuration;

public sealed class ServiceConfiguration : IEntityTypeConfiguration<Service>
{
    public void Configure(EntityTypeBuilder<Service> builder)
    {
        builder.ToTable("Services");
        builder.Property(p => p.Title).IsRequired().HasMaxLength(100);
        builder.Property(p => p.Description).HasMaxLength(500);
        builder.Property(p => p.IconUrl).HasMaxLength(300);

        builder.HasData(
               new Service { Id = "S001", Title = "24/7 Roadside Assistance", Description = "We’ve got your back on every kilometer.", IconUrl = "/icons/assistance.svg" },
               new Service { Id = "S002", Title = "Full Insurance", Description = "Drive safe – all rentals include comprehensive coverage.", IconUrl = "/icons/insurance.svg" }
           );
    }
}
