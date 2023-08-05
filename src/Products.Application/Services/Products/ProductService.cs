using Products.Application.Common.Interfaces.Persistence;
using Products.Domain.Entities;

namespace Products.Application.Services.Products;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public CreateProductResult CreateProduct(string name, string description, decimal price)
    {
        // 1. Validate product doesn't exists
        if (_productRepository.GetProductByName(name) is not null)
        {
            throw new Exception("Product already exists");
        }

        // 2. Create product (generated unique Id) and persist to DB
        var product = new Product
        {
            Name = name,
            Description = description,
            Price = price
        };
        _productRepository.AddProduct(product);

        return new CreateProductResult(product);
    }
}