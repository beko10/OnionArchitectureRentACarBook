using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureRentACarBook.Application.Repositories.AboutRepository;
using OnionArchitectureRentACarBook.Application.Repositories.BannerRepository;
using OnionArchitectureRentACarBook.Application.Repositories.BrandRepository;
using OnionArchitectureRentACarBook.Application.Repositories.CarFeatureRepository;
using OnionArchitectureRentACarBook.Application.Repositories.CarRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Persistence.Context;
using OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreAboutRepository;
using OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreBannerRepository;
using OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreBrandRepository;
using OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreCarFeatureRepository;
using OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreCarRepository;

namespace OnionArchitectureRentACarBook.Persistence;

public static class ServicesRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services,IConfiguration configuration)
    {
        // DbContext registration with connection string from configuration
        services.AddDbContext<AppDbContext>(opt =>
            opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


        services.AddScoped<IAboutReadRepository, EfCoreAboutReadRepository>();
        services.AddScoped<IAboutWriteRepository, EfCoreAboutWriteRepository>();
        services.AddScoped<IBrandReadRepository, EfCoreBrandReadRepository>();
        services.AddScoped<IBrandWriteRepository, EfCoreBrandWriteRepository>();
        services.AddScoped<IBannerReadRepository, EfCoreBannerReadRepository>();
        services.AddScoped<IBannerWriteRepository, EfCoreBannerWriteRepository>();
        services.AddScoped<ICarFeatureReadRepository, EfCoreCarFeatureReadRepository>();
        services.AddScoped<ICarFeatureWriteRepository, EfCoreCarFeatureWriteRepository>();
        services.AddScoped<ICarWriteRepository, EfCoreCarWriteRepository>();
        services.AddScoped<ICarReadRepository, EfCoreCarReadRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
    }
}
