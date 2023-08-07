using ErrorOr;
using MediatR;
using Products.Domain.Common.Models;
using Products.Domain.Product;

namespace Products.Application.Products.Commands.CreateProduct;

public record CreateProductCommand(
    string Name,
    string Description,
    decimal Price
) : IRequest<ErrorOr<Product>>;