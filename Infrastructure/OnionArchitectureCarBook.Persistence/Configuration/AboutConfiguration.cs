using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using OnionArchitectureCarBook.Domain.Entities;

public sealed class AboutConfiguration : IEntityTypeConfiguration<About>
{
    public void Configure(EntityTypeBuilder<About> builder)
    {
        builder.ToTable("Abouts");

        builder.Property(p => p.Title)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(p => p.Description)
               .IsRequired()
               .HasMaxLength(1000);

        builder.Property(p => p.ImageUrl)
               .HasMaxLength(300);


        builder.HasData(
                new About
                {
                    Id = "AB001",
                    Title = "Welcome to CarBook",
                    Description = "Premium car rental platform with a wide selection of vehicles and 24/7 support.",
                    ImageUrl = "/images/about/about_us.jpg"
                }
            );
    }
}