using Microsoft.EntityFrameworkCore;
using WebStore.Application.Interfaces.Repositories;
using WebStore.Domain.Entities;
using WebStore.Infrastructure.Data;

namespace WebStore.Infrastructure.Repositories;

public class ProductRepository : BaseRepository<Product>, IProductRepository
{
    public ProductRepository(StoreDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Product>> GetByCategoryIdAsync(int categoryId)
    {
        return await _context.Products
            .Where(p => p.CategoryId == categoryId)
            .ToListAsync();
    }
}