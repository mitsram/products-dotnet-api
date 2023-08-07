using Products.Domain.Product;

namespace Products.Application.Common.Interfaces.Persistence;

public interface IProductRepository
{
    void Add(Product product);
}