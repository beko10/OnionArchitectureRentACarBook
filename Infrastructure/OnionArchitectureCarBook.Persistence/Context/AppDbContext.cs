using Microsoft.EntityFrameworkCore;
using OnionArchitectureCarBook.Domain.Common;
using OnionArchitectureCarBook.Domain.Entities;
using System.Reflection;

namespace OnionArchitectureCarBook.Persistence.Context;

public sealed class AppDbContext : DbContext
{
    public DbSet<About> Abouts { get; set; }
    public DbSet<Banner> Banners { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<CarDescription> CarDescriptions { get; set; }
    public DbSet<CarFeature> CarFeatures { get; set; }
    public DbSet<CarPricing> CarPricings { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<FooterAdress> FooterAdresses { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Pricing> Pricings { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }

    public AppDbContext(DbContextOptions options):base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(modelBuilder);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var entityChanges = ChangeTracker.Entries<BaseEntity>();

        foreach (var entity in entityChanges)
        {
            if(entity.State == EntityState.Added)
            {
                entity.Entity.CreatedDate = DateTime.UtcNow;
            }
            if (entity.State == EntityState.Modified)
            {
                entity.Entity.UpdatedDate = DateTime.UtcNow;
            }
        }

        return base.SaveChangesAsync(cancellationToken);    
    }

}
