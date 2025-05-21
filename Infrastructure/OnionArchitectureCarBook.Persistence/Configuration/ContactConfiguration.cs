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

        builder.HasData(
               new Contact
               {
                   Id = "CT001",
                   Name = "Demo User",
                   Email = "demo@carbook.com",
                   Subject = "Sample inquiry",
                   Message = "How much would it cost to rent an Audi A4 for a week?",
                   SendDate = new DateTime(2025, 5, 1)
               }
           );
    }
}
