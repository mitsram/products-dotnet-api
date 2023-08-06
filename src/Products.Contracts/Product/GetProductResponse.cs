namespace Products.Contracts.Product;

public record GetProductResponse(
    Guid Id,
    string Name,
    string Description,
    decimal Price
);