using BuberDinner.Domain.DinnerAggregate.ValueObjects;
using Products.Domain.Common.Models;
using Products.Domain.ProductAggregate.Events;
using Products.Domain.ProductAggregate.ValueObjects;

namespace Products.Domain.ProductAggregate;

public sealed class Product : AggregateRoot<ProductId, Guid>
{
    public string Name { get; }
    public string Description { get; }
    public Price Price { get; }

    private Product(
        ProductId productId,
        string name,
        string description,
        Price price) : base(productId)
    {
        Name = name;
        Description = description;
        Price = price;
    }

    public static Product Create(
        string name,
        string description,
        Price price)
    {
        var product = new Product(
            ProductId.CreateUnique(),
            name,
            description,
            price
        );

        product.AddDomainEvent(new ProductCreated(product));

        return product;
    }
    
    #pragma warning disable CS8618
    private Product()
    {
    }
    #pragma warning restore CS8618
}