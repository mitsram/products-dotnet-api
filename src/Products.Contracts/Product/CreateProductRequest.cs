namespace Products.Contracts.Product;

public record CreateProductRequest(
    string Name,
    string Description,
    decimal Price    
);