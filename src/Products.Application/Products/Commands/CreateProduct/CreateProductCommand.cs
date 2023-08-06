using ErrorOr;
using MediatR;
using Products.Application.Products.Common;

namespace Products.Application.Products.Commands.CreateProduct;

public record CreateProductCommand(
    string Name,
    string Description,
    decimal Price
) : IRequest<ErrorOr<ProductResult>>;