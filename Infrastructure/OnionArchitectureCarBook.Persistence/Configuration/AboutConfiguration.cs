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
    }
}