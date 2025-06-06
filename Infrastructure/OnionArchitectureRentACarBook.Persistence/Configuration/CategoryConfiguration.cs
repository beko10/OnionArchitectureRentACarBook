using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitectureRentACarBook.Domain.Entities;

namespace OnionArchitectureRentACarBook.Persistence.Configuration;

public sealed class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");
        builder.Property(p => p.Name).IsRequired().HasMaxLength(100);

        builder.HasData(
                new Category { Id = "C001", Name = "Sedan" },
                new Category { Id = "C002", Name = "SUV" }
            );

    }
}
