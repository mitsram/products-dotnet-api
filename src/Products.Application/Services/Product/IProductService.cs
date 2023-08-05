namespace Products.Application.Services.Product;

public interface IProductService
{
    CreateProductResult CreateProduct(string Name,
        string Description,
        decimal Price
    );
}