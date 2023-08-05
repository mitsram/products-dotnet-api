using Products.Application.Common.Interfaces.Persistence;
using Products.Domain.Entities;

namespace Products.Infrastructure.Persistence;

public class ProductRepository : IProductRepository
{
    private static readonly List<Product> _products = new();

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public Product? GetProductByName(string name)
    {
        return _products.SingleOrDefault(p => p.Name == name);
    }
}