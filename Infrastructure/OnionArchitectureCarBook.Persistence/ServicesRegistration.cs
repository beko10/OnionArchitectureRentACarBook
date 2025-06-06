using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureRentACarBook.Application.Repositories.AboutRepository;
using OnionArchitectureRentACarBook.Application.UnitOfWork;
using OnionArchitectureRentACarBook.Persistence.Context;
using OnionArchitectureRentACarBook.Persistence.Repositories.EfCoreAboutRepository;

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
        services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
    }
}
