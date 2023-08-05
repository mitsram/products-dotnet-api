namespace Products.Contracts.Product;

public record CreateProductResponse(
    Guid Id,
    string Name,
    string Description,
    decimal Price
);