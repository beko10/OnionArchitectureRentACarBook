using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitectureCarBook.Domain.Entities;

namespace OnionArchitectureCarBook.Persistence.Configurations;

public sealed class BannerConfiguration : IEntityTypeConfiguration<Banner>
{
    public void Configure(EntityTypeBuilder<Banner> builder)
    {
        builder.ToTable("Banners");

        builder.Property(p => p.Title).IsRequired().HasMaxLength(100);
        builder.Property(p => p.Description).IsRequired().HasMaxLength(1000);
        builder.Property(p => p.VideoUrl).HasMaxLength(300);
    }
}