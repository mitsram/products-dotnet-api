namespace Products.Contracts.Products;

public record CreateProductRequest(
    string Name,
    string Description,
    decimal Price    
);