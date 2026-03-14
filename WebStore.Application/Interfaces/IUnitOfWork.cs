using WebStore.Application.Interfaces.Repositories;

namespace WebStore.Application.Interfaces;

public interface IUnitOfWork
{
    ICategoryRepository Categories { get; }
    IProductRepository Products { get; }
    IUserRepository Users { get; }
    ICartRepository Carts { get; }
    IOrderRepository Orders { get; }

    Task<int> SaveChangesAsync();
}