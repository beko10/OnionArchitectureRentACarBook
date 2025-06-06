using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Persistence.Configuration;

public sealed class SocialMediaConfiguration : IEntityTypeConfiguration<SocialMedia>
{
    public void Configure(EntityTypeBuilder<SocialMedia> builder)
    {
        builder.ToTable("SocialMedias");
        builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
        builder.Property(p => p.Url).IsRequired().HasMaxLength(300);
        builder.Property(p => p.Icon).HasMaxLength(100);

        builder.HasData(
                new SocialMedia { Id = "SM001", Name = "Instagram", Url = "https://instagram.com/carbook", Icon = "fa-instagram" },
                new SocialMedia { Id = "SM002", Name = "Twitter", Url = "https://x.com/carbook", Icon = "fa-twitter" }
            );
    }
}
