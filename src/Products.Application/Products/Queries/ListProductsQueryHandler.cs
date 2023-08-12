using Products.Application.Common.Interfaces.Persistence;
using ErrorOr;
using MediatR;
using Products.Application.Products.Queries;
using Products.Domain.ProductAggregate;

namespace Products.Application.Dinners.Queries.ListDinners;

public class ListProductsQueryHandler : IRequestHandler<ListProductsQuery, ErrorOr<List<Product>>>
{
    private readonly IProductRepository _productRepository;

    public ListProductsQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<ErrorOr<List<Product>>> Handle(ListProductsQuery request, CancellationToken cancellationToken)
    {        
        return await _productRepository.ListAsync();
    }
}