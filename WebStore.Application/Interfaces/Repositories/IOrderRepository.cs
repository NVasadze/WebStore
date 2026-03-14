using WebStore.Domain.Entities;

namespace WebStore.Application.Interfaces.Repositories;

public interface IOrderRepository : IBaseRepository<Order>
{
    Task<IEnumerable<Order>> GetByUserIdAsync(int userId);
}