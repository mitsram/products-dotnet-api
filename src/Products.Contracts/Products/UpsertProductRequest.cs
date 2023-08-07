namespace Products.Contracts.Products;

public record UpsertProductRequest(
    string Name,
    string Description,
    decimal Price    
);