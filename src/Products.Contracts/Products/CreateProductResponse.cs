namespace Products.Contracts.Products;

public record CreateProductResponse(
    Guid Id,
    string Name,
    string Description,
    decimal Price
);