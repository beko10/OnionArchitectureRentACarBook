using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureCarBook.Application.Repositories.AboutRepository;
using OnionArchitectureCarBook.Application.UnitOfWork;
using OnionArchitectureCarBook.Persistence.Context;
using OnionArchitectureCarBook.Persistence.Repositories.EfCoreAboutRepository;

namespace OnionArchitectureCarBook.Persistence;

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
