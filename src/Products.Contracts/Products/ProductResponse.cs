namespace Products.Contracts.Products;

public record ProductResponse(
    string Id,
    string Name,
    string Description,
    decimal Price
);