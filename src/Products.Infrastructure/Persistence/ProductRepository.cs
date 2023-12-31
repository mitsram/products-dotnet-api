using Microsoft.EntityFrameworkCore;
using Products.Application.Common.Interfaces.Persistence;
using Products.Domain.ProductAggregate;

namespace Products.Infrastructure.Persistence;

public class ProductRepository : IProductRepository
{
    private readonly ProductDbContext _dbContext;

    public ProductRepository(ProductDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddAsync(Product product)
    {
        await _dbContext.AddAsync(product);

        await _dbContext.SaveChangesAsync();
    }

    public async Task<List<Product>> ListAsync()
    {
        return await _dbContext.Products.ToListAsync();
    }
}