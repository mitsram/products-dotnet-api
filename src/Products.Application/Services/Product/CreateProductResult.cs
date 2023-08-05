namespace Products.Application.Services.Product;

public record CreateProductResult(
    Guid Id,
    string Name,
    string Description,
    decimal Price
);