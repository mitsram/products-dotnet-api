namespace Products.Contracts.Products;

public record GetProductRequest(
    string Name,
    string Description,
    decimal Price    
);