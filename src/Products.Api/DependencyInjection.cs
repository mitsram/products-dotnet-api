using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Products.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {        
        services.AddMappings();
        return services;
    }
}