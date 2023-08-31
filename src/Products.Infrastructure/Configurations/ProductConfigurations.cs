
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.Domain.ProductAggregate;
using Products.Domain.ProductAggregate.ValueObjects;

public class ProductConfigurations : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        
    }

    private static void ConfigureProductsTable(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");

        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id)
            .ValueGeneratedNever()
            .HasConversion(
                id => id.Value,
                value => ProductId.Create(value)
            );
        builder.Property(p => p.Name)
            .HasMaxLength(100);
        builder.Property(p => p.Description)
            .HasMaxLength(100);
        builder.OwnsOne(p => p.Price, pb => pb.Property(d => d.Amount)
            .HasColumnType("decimal(10,4)"));
    }
}