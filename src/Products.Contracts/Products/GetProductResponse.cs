namespace Products.Contracts.Products;

public record GetProductResponse(
    Guid Id,
    string Name,
    string Description,
    decimal Price
);