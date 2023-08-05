using Products.Domain.Entities;

namespace Products.Application.Common.Interfaces.Persistence;

public interface IProductRepository
{
    void AddProduct(Product product);
    Product? GetProductByName(string name);
}