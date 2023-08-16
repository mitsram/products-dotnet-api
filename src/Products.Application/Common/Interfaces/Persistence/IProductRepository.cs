

using Products.Domain.ProductAggregate;

namespace Products.Application.Common.Interfaces.Persistence;

public interface IProductRepository
{
    Task AddAsync(Product dinner);
    Task<List<Product>> ListAsync();
}