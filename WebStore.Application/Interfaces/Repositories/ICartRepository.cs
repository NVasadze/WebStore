using WebStore.Domain.Entities;

namespace WebStore.Application.Interfaces.Repositories;

public interface ICartRepository : IBaseRepository<Cart>
{
    Task<Cart?> GetByUserIdAsync(int userId);
}