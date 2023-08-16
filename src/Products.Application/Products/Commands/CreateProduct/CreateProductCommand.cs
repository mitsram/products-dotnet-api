using ErrorOr;
using MediatR;
using Products.Domain.Common.Models;
using Products.Domain.ProductAggregate;

namespace Products.Application.Products.Commands.CreateProduct;

public record CreateProductCommand(
    string Name,
    string Description,
    ProductPriceCommand Price
) : IRequest<ErrorOr<Product>>;

public record ProductPriceCommand(
    decimal Amount,
    string Currency);