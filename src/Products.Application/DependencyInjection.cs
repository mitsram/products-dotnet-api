using Microsoft.Extensions.DependencyInjection;
using Products.Application.Services.Products;
using Products.Application.Services.Products.Commands;
using Products.Application.Services.Products.Queries;

namespace Products.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {        
        services.AddScoped<IProductCommandService, ProductCommandService>();
        services.AddScoped<IProductQueryService, ProductQueryService>();
        return services;
    }
}