using Microsoft.Extensions.DependencyInjection;

namespace OnionArchitectureCarBook.Application;

public static class ServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Register MediatR for handling commands and queries
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServiceRegistration).Assembly));
        // Register AutoMapper for object mapping
        services.AddAutoMapper(typeof(ServiceRegistration));
        // Register other application services here as needed

        return services;
    }
}
