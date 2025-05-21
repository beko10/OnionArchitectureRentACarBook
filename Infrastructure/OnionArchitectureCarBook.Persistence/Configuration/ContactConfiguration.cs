using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitectureCarBook.Domain.Entities;

namespace OnionArchitectureCarBook.Persistence.Configurations;

public sealed class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.ToTable("Contacts");

        builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
        builder.Property(p => p.Email).IsRequired().HasMaxLength(100);
        builder.Property(p => p.Subject).HasMaxLength(150);
        builder.Property(p => p.Message).IsRequired().HasMaxLength(1000);

        builder.Property(p => p.SendDate)
               .IsRequired()
               .HasDefaultValueSql("GETDATE()");
    }
}
