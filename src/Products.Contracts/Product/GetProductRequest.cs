namespace Products.Contracts.Product;

public record GetProductRequest(
    string Name,
    string Description,
    decimal Price    
);