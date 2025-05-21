using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitectureCarBook.Domain.Entities;

namespace OnionArchitectureCarBook.Persistence.Configurations;

public sealed class TestimonialConfiguration : IEntityTypeConfiguration<Testimonial>
{
    public void Configure(EntityTypeBuilder<Testimonial> builder)
    {
        builder.ToTable("Testimonials");
        builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
        builder.Property(p => p.Title).HasMaxLength(100);
        builder.Property(p => p.Comment).IsRequired().HasMaxLength(1000);
        builder.Property(p => p.ImageUrl).HasMaxLength(300);


        builder.HasData(
               new Testimonial
               {
                   Id = "TST001",
                   Name = "John Doe",
                   Title = "Frequent Traveler",
                   Comment = "Smooth booking process and very clean cars. Highly recommend!",
                   ImageUrl = "/images/testimonials/john.jpg"
               }
           );
    }
}
