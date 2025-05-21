using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitectureCarBook.Domain.Entities;

namespace OnionArchitectureCarBook.Persistence.Configurations;

public sealed class SocialMediaConfiguration : IEntityTypeConfiguration<SocialMedia>
{
    public void Configure(EntityTypeBuilder<SocialMedia> builder)
    {
        builder.ToTable("SocialMedias");
        builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
        builder.Property(p => p.Url).IsRequired().HasMaxLength(300);
        builder.Property(p => p.Icon).HasMaxLength(100);
    }
}
