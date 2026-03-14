using Microsoft.EntityFrameworkCore;
using WebStore.Application.Interfaces.Repositories;
using WebStore.Domain.Entities;
using WebStore.Infrastructure.Data;

namespace WebStore.Infrastructure.Repositories;

public class CartRepository : BaseRepository<Cart>, ICartRepository
{
    public CartRepository(StoreDbContext context) : base(context)
    {
    }

    public async Task<Cart?> GetByUserIdAsync(int userId)
    {
        return await _context.Carts
            .Include(c => c.Items)
            .FirstOrDefaultAsync(c => c.UserId == userId);
    }
}