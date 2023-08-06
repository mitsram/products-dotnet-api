using ErrorOr;
using Products.Application.Services.Products.Common;

namespace Products.Application.Services.Products.Queries;

public interface IProductQueryService
{
    ErrorOr<ProductResult> CreateProduct(string Name, string Description, decimal Price);
}