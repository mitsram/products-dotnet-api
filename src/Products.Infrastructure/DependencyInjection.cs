using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Products.Application.Common.Interfaces.Persistence;
using Products.Infrastructure.Persistence;
using Products.Infrastructure.Persistence.Interceptors;

namespace Products.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddPersistence();
        return services;
    }

    public static IServiceCollection AddPersistence(this IServiceCollection services)
    {
        services.AddDbContext<ProductDbContext>(options =>
            options.UseSqlServer("Server=localhost;Database=Product;User Id=sa;Password=SecurePassword;TrustServerCertificate=true"));
        services.AddScoped<PublishDomainEventsInterceptor>();
        services.AddScoped<IProductRepository, ProductRepository>();
        return services;
    }
}