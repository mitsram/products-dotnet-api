namespace Products.Contracts.Products;

public record CreateProductRequest(
    string Name,
    string Description,
    ProductPrice Price    
);

public record ProductPrice(
    decimal Amount,
    string Currency);