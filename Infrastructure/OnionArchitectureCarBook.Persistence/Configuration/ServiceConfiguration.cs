using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitectureCarBook.Domain.Entities;

namespace OnionArchitectureCarBook.Persistence.Configurations;

public sealed class ServiceConfiguration : IEntityTypeConfiguration<Service>
{
    public void Configure(EntityTypeBuilder<Service> builder)
    {
        builder.ToTable("Services");
        builder.Property(p => p.Title).IsRequired().HasMaxLength(100);
        builder.Property(p => p.Description).HasMaxLength(500);
        builder.Property(p => p.IconUrl).HasMaxLength(300);
    }
}
