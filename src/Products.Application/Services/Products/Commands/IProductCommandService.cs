using ErrorOr;
using Products.Application.Services.Products.Common;

namespace Products.Application.Services.Products.Commands;

public interface IProductCommandService
{
    ErrorOr<ProductResult> CreateProduct(string Name, string Description, decimal Price);
}