
using ErrorOr;
using MediatR;
using Products.Application.Common.Interfaces.Persistence;
using Products.Domain.Entities;
using Products.Application.Products.Common;
using Products.Domain.Common.Errors;

namespace Products.Application.Products.Commands.CreateProduct;

public class CreateProductCommandHandler :
    IRequestHandler<CreateProductCommand, ErrorOr<ProductResult>>
{
    private readonly IProductRepository _productRepository;

    public CreateProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<ErrorOr<ProductResult>> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        // 1. Validate product doesn't exists
        if (_productRepository.GetProductByName(command.Name) is not null)
        {
            return Errors.Product.DuplicateName;
        }

        // 2. Create product (generated unique Id) and persist to DB
        var product = new Product
        {
            Name = command.Name,
            Description = command.Description,
            Price = command.Price
        };
        _productRepository.AddProduct(product);

        return new ProductResult(product);
    }
}