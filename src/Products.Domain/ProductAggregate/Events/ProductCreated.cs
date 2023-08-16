using Products.Domain.Common.Models;

namespace Products.Domain.ProductAggregate.Events;

public record ProductCreated(Product Product) : IDomainEvent;