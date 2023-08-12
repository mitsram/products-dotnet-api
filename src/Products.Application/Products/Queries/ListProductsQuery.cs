using ErrorOr;
using MediatR;
using Products.Domain.ProductAggregate;

namespace Products.Application.Products.Queries;

public record ListProductsQuery(): IRequest<ErrorOr<List<Product>>>;