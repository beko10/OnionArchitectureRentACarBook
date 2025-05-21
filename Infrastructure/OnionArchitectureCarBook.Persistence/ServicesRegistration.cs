using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureCarBook.Persistence.Context;

namespace OnionArchitectureCarBook.Persistence;

public static class ServicesRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(@"Server=MSı\SQLEXPRESS;Database=CarBookDb;Trusted_Connection=true;TrustServerCertificate=true"));
    }
}
