namespace Products.Contracts.Products;

public record ProductResponse(
    string Id,
    string Name,
    string Description,
    Price Price
);

public record Price(
    decimal Amount,
    string Currency);