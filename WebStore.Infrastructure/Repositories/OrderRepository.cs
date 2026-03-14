using Microsoft.EntityFrameworkCore;
using WebStore.Application.Interfaces.Repositories;
using WebStore.Domain.Entities;
using WebStore.Infrastructure.Data;

namespace WebStore.Infrastructure.Repositories;

public class OrderRepository : BaseRepository<Order>, IOrderRepository
{
    public OrderRepository(StoreDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Order>> GetByUserIdAsync(int userId)
    {
        return await _context.Orders
            .Where(o => o.UserId == userId)
            .ToListAsync();
    }
}