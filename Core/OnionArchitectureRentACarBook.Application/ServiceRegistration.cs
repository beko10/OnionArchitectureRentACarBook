using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureRentACarBook.Application.Common.Behaviors;
using OnionArchitectureRentACarBook.Domain.Entities;
using System.Reflection;

namespace OnionArchitectureRentACarBook.Application;

public static class ServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(cfg => {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehavior<,>));
        });

        services.AddAutoMapper(typeof(ServiceRegistration));

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        return services;
    }
}
