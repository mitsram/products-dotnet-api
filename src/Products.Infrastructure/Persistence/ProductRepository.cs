using Products.Application.Common.Interfaces.Persistence;
using Products.Domain.Product;

namespace Products.Infrastructure.Persistence;

public class ProductRepository : IProductRepository
{
    private readonly List<Product> _products = new();
    public void Add(Product product)
    {
        _products.Add(product);
    }
}