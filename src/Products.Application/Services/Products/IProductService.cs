using ErrorOr;

namespace Products.Application.Services.Products;

public interface IProductService
{
    ErrorOr<CreateProductResult> CreateProduct(
        string Name,
        string Description,
        decimal Price
    );
}