using Products.Domain.Common.Models;
using Products.Domain.Product.ValueObjects;

namespace Products.Domain.Product;

public sealed class Product : AggregateRoot<ProductId>
{
    public string Name { get; }
    public string Description { get; }
    public decimal Price { get; }

    private Product(
        ProductId productId,
        string name,
        string description,
        decimal price) : base(productId)
    {
        Name = name;
        Description = description;
        Price = price;
    }

    public static Product Create(
        string name,
        string description,
        decimal price)
    {
        return new(
            ProductId.CreateUnique(),
            name,
            description,
            price
        );
    }
}