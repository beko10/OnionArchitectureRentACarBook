using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitectureCarBook.Domain.Entities;

namespace OnionArchitectureCarBook.Persistence.Configurations;

public sealed class FooterAdressConfiguration : IEntityTypeConfiguration<FooterAdress>
{
    public void Configure(EntityTypeBuilder<FooterAdress> builder)
    {
        builder.ToTable("FooterAdresses");
        builder.Property(p => p.Description).HasMaxLength(200);
        builder.Property(p => p.Adress).HasMaxLength(200);
        builder.Property(p => p.Phone).HasMaxLength(20);
        builder.Property(p => p.Email).HasMaxLength(100);
    }
}
