namespace Products.Application.Services.Products;

public interface IProductService
{
    CreateProductResult CreateProduct(
        string Name,
        string Description,
        decimal Price
    );
}