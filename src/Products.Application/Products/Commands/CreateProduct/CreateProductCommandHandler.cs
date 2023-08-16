using BuberDinner.Domain.DinnerAggregate.ValueObjects;
using ErrorOr;
using MediatR;
using Products.Application.Common.Interfaces.Persistence;
using Products.Domain.ProductAggregate;

namespace Products.Application.Products.Commands.CreateProduct;

public class CreateProductCommandHandler :
    IRequestHandler<CreateProductCommand, ErrorOr<Product>>
{
    private readonly IProductRepository _productRepository;

    public CreateProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<ErrorOr<Product>> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        var product = Product.Create(
            command.Name,
            command.Description,
            Price.Create(
                command.Price.Amount,
                command.Price.Currency
            )
        );

        await _productRepository.AddAsync(product);

        return product;
    }
}