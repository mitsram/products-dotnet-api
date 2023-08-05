namespace Products.Application.Services.Product;

public class ProductService : IProductService
{
    public CreateProductResult CreateProduct(string name, string description, decimal price)
    {
        return new CreateProductResult(
            Guid.NewGuid(),
            name,
            description,
            price
        );
    }
}