using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureRentACarBook.Application.ApplicationServices.BusinessRuleServices.AboutBusinessRuleService;
using OnionArchitectureRentACarBook.Application.ApplicationServices.BusinessRuleServices.AboutRuleService;
using OnionArchitectureRentACarBook.Application.Common.Behaviors;
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

        services.AddScoped<IAboutBusinessRuleService, AboutBusinessRuleService>();
        return services;
    }
}
