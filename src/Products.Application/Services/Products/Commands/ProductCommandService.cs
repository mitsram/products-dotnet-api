using ErrorOr;
using Products.Application.Common.Errors;
using Products.Application.Common.Interfaces.Persistence;
using Products.Application.Services.Products.Common;
using Products.Domain.Common.Errors;
using Products.Domain.Entities;

namespace Products.Application.Services.Products.Commands;

public class ProductCommandService : IProductCommandService
{
    private readonly IProductRepository _productRepository;

    public ProductCommandService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public ErrorOr<ProductResult> CreateProduct(string name, string description, decimal price)
    {
        // 1. Validate product doesn't exists
        if (_productRepository.GetProductByName(name) is not null)
        {
            // throw new Exception("Product already exists");
            // throw new DuplicateNameException();
            return Errors.Product.DuplicateName;
        }

        // 2. Create product (generated unique Id) and persist to DB
        var product = new Product
        {
            Name = name,
            Description = description,
            Price = price
        };
        _productRepository.AddProduct(product);

        return new ProductResult(product);
    }
}