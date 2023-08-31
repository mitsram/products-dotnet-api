

using Products.Domain.ProductAggregate;
using Products.Domain.ProductAggregate.ValueObjects;

namespace Products.Application.Common.Interfaces.Persistence;

public interface IProductRepository
{
    Task AddAsync(Product dinner);
    Task<bool> ExistsAsync(ProductId productId);
    Task<List<Product>> ListAsync();
}