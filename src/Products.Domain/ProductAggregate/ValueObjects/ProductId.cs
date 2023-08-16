using Products.Domain.Common.Models;

namespace Products.Domain.ProductAggregate.ValueObjects;

public sealed class ProductId : AggregateRootId<Guid>
{
    private ProductId(Guid value) : base(value)
    {
    }

    public static ProductId CreateUnique()
    {
        return new ProductId(Guid.NewGuid());
    }

    public static ProductId Create(Guid value)
    {
        return new ProductId(value);
    }
}