using ErrorOr;
using MediatR;
using Products.Application.Common.Interfaces.Persistence;
using Products.Domain.Product;

namespace Products.Application.Products.Commands.CreateProduct;

public class CreateProductCommandHandler :
    IRequestHandler<CreateProductCommand, ErrorOr<Product>>
{
    private readonly IProductRepository _productRepository;

    public CreateProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<ErrorOr<Product>> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        
        // Create Product
        var product = Product.Create(
            request.Name,
            request.Description,
            request.Price
        );
        // Persist Product
        _productRepository.Add(product);

        // Return Product
        return product;
    }
}